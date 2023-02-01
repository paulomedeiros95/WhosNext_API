using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Domain.Account;
using WhosNext_Domain.Interfaces;
using WhosNext_Dto.Request;
using WhosNext_Dto.Response;
using WhosNext_Dto.ValueObjects;
using WhosNext_Services.Services.Interfaces;

namespace WhosNext_Services.Services.Account
{
    public class AccountService : IAccountService
    {
        #region Fields
        private readonly IBaseRepository<AccountDomain> _accountRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor

        public AccountService(IBaseRepository<AccountDomain> accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        #endregion

        #region Methods
        public async Task<List<AccountResponseDto>> GetAll()
        {
            var accounts = await _accountRepository.Select();

            var fatherAccounts = accounts.Where(x => !x.AcceptIncommings).ToList();

            return SortResult(fatherAccounts);
        }

        public async Task<List<AccountSuggestedNextResponseDto>> GetNextDetails()
        {
            var accounts = await _accountRepository.Select();

            if (accounts.Count == 0)
                return new List<AccountSuggestedNextResponseDto>();

            //TODO: combinar jogo com o app no caso onde não houver conta pai registrada.
            var fatherAccounts = _mapper
                .Map<List<AccountSuggestedNextResponseDto>>(accounts.Where(x => !x.AcceptIncommings));

            GetSuggestedCode(accounts, fatherAccounts);

            return fatherAccounts;

        }

        public async Task<AccountResponseDto> Create(AccountRequestDto accountRequest)
        {
            if (String.IsNullOrEmpty(accountRequest.Name) || String.IsNullOrEmpty(accountRequest.ExternalCode))
                throw new Exception("Dados inválidos.");

            var exist = await _accountRepository.SelectFirstBy(x => x.ExternalCode == accountRequest.ExternalCode);

            if (exist != null)
                throw new Exception("O código informado já está sendo utilizado, por gentileza refaça a operação utilizando um código sugerido ou diferente do utilizado.");
            
            var fatherAccount = await _accountRepository.SelectFirstBy(x=> x.Id == accountRequest.FatherId);

            if (fatherAccount == null)
                throw new Exception("Conta pai não localizada.");

            var buildAccount = _mapper.Map<AccountDomain>(accountRequest);

            buildAccount.UpperId = fatherAccount.Id;

            return _mapper.Map<AccountResponseDto>(await _accountRepository.Insert(buildAccount));
        }


        #region Private Methods

        private static List<AccountResponseDto> SortResult(
            List<AccountDomain> fatherAccounts)
        {
            List<AccountResponseDto> result = new();

            foreach (var account in fatherAccounts)
            {
                AccountResponseDto buildAccount = new();
                buildAccount.Id = account.Id;
                buildAccount.Name = account.Name;
                buildAccount.ExternalCode = account.ExternalCode;
                buildAccount.Lowers = new List<ChildVO>();

                foreach (var lower in account.Lowers)
                {
                    ChildVO buildChildLower = new();
                    buildChildLower.Id = lower.Id;
                    buildChildLower.Name = lower.Name;
                    buildChildLower.ExternalCode = lower.ExternalCode;
                    buildAccount.Lowers.Add(buildChildLower);
                }

                buildAccount.Lowers = buildAccount.Lowers.OrderBy(x => x.ExternalCode).ToList();
                result.Add(buildAccount);
            }

            return result;
        }

        private static void GetSuggestedCode(
        IList<AccountDomain> accounts,
        List<AccountSuggestedNextResponseDto> fatherAccounts)
        {
            //Preenchendo sugestões de códigos a serem utilizados no cadastro.
            foreach (var account in fatherAccounts)
            {
                var accountKey = accounts.Where(x => x.Id == account.Id).FirstOrDefault();

                if (accountKey.Lowers.Count > 0)
                {
                    var lastCodeOrdered = SortLastCode(accountKey.Lowers.Select(x => x.ExternalCode).ToList());
                    account.SuggestedCode = GenerateSuggestedCode(lastCodeOrdered, accountKey.ExternalCode);
                }
                else
                {
                    account.SuggestedCode = $"{accountKey.ExternalCode}.1";
                }

            }
        }

        private static string SortLastCode(
            List<string> codes)
        {
            codes.Sort((x, y) =>
            {
                string[] xParts = x.Split('.');
                string[] yParts = y.Split('.');
                int xValue = int.Parse(xParts[0]) * 10 + int.Parse(xParts[1]);
                int yValue = int.Parse(yParts[0]) * 10 + int.Parse(yParts[1]);
                return xValue.CompareTo(yValue);
            });

            return codes.Last().ToString();
        }

        private static string GenerateSuggestedCode(
            string lastChildAccount,
            string parentAccount)
        {
            string[] parentArray = parentAccount.Split('.');
            string[] lastChildArray = lastChildAccount.Split('.');

            int lastNumber = int.Parse(lastChildArray[lastChildArray.Length - 1]);
            lastNumber++;

            string nextSuggestedChildCode = parentAccount + "." + lastNumber;

            return nextSuggestedChildCode;
        }

        #endregion

        #endregion

    }
}
