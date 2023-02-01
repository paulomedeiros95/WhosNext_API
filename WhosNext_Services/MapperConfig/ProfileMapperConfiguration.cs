using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Domain.Account;
using WhosNext_Dto.Request;
using WhosNext_Dto.Response;
using WhosNext_Dto.ValueObjects;

namespace WhosNext_Services.MapperConfig
{
    public class ProfileMapperConfiguration : Profile
    {
        public ProfileMapperConfiguration()
        {
            #region Acount

            CreateMap<AccountResponseDto, AccountDomain>().ReverseMap();
            CreateMap<AccountRequestDto, AccountDomain>().ReverseMap();
            CreateMap<List<AccountResponseDto>, AccountDomain>().ReverseMap();
            CreateMap<List<AccountDomain>, AccountResponseDto>().ReverseMap();
            CreateMap<AccountResponseDto, AccountSuggestedNextResponseDto>().ReverseMap();            
            CreateMap<AccountResponseDto, ChildVO>().ReverseMap();
            CreateMap<List<ChildVO>, AccountDomain>();
            CreateMap<List<AccountDomain>, ChildVO>();
            CreateMap<List<AccountResponseDto>, AccountDomain>();
            CreateMap<List<AccountDomain>, AccountResponseDto>();
            CreateMap<AccountSuggestedNextResponseDto, ChildVO>().ReverseMap();
            CreateMap<AccountSuggestedNextResponseDto, AccountDomain>().ReverseMap();

            #endregion
        }
    }
}
