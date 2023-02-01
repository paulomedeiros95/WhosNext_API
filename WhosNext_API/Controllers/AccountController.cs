using Microsoft.AspNetCore.Mvc;
using WhosNext_API.Controllers.Base;
using WhosNext_Dto.Request;
using WhosNext_Dto.Response;
using WhosNext_Services.Services.Interfaces;

namespace WhosNext_API.Controllers
{
    //[Authorize] --> TODO: Add Auth
    [ApiController]
    [Route("[controller]")]
    public class AccountController : BaseController
    {
        #region Fields

        private readonly IAccountService _accountService;

        #endregion

        #region Constructor


        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        #endregion

        #region Endpoints
        [HttpPost("Create")]
        [ProducesResponseType(typeof(List<AccountResponseDto>), 200)]
        [ProducesResponseType(typeof(ErrorResponseBaseDto), 404)]
        public async Task<IActionResult> Create([FromBody] AccountRequestDto account)
        {
            if (account == null)
                return BadRequest();
            try
            {
                return new JsonResult(await _accountService.Create(account));
            }
            catch (System.Exception ex)
            {
                return BadRequest(CreateObjectError(ex.Message));
            }
        }


        /// <summary>
        /// Utilize este endpoint para buscar todas as contas registradas e ativas.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<AccountResponseDto>), 200)]
        [ProducesResponseType(typeof(ErrorResponseBaseDto), 404)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return new JsonResult(await _accountService.GetAll());
            }
            catch (System.Exception ex)
            {
                return BadRequest(CreateObjectError(ex.Message));
            }
        }

        /// <summary>
        /// Utilize este endpoint no onload da tela "Inserir conta", pois através deste endpoint você obterá
        /// as informações para popular o dropdown "Conta Pai" e a sugestão de código para o campo "Códio", ambas amarradas.</summary>
        /// <returns></returns>
        [HttpGet("NextDetaiis")]
        [ProducesResponseType(typeof(List<AccountSuggestedNextResponseDto>), 200)]
        [ProducesResponseType(typeof(ErrorResponseBaseDto), 404)]
        public async Task<IActionResult> NextDetaiis()
        {
            try
            {
                return new JsonResult(await _accountService.GetNextDetails());
            }
            catch (System.Exception ex)
            {
                return BadRequest(CreateObjectError(ex.Message));
            }
        }

        //[HttpGet("Create")]
        //[ProducesResponseType(typeof(List<AccountResponseDto>), 200)]
        //[ProducesResponseType(typeof(ErrorResponseBaseDto), 404)]
        //public async Task<IActionResult> Create([FromBody] AccountRequestDto account)
        //{
        //    try
        //    {
        //        return new JsonResult(await _accountService.GetAll());
        //    }
        //    catch (System.Exception ex)
        //    {
        //        return BadRequest(CreateObjectError(ex.Message));
        //    }
        //}
        #endregion

    }
}
