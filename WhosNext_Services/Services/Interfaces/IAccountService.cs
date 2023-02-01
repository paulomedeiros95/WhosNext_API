using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Dto.Request;
using WhosNext_Dto.Response;

namespace WhosNext_Services.Services.Interfaces
{
    public interface IAccountService
    {
        Task<List<AccountResponseDto>> GetAll();

        Task<AccountResponseDto> Create(AccountRequestDto account);

        Task<List<AccountSuggestedNextResponseDto>> GetNextDetails();
    }
}
