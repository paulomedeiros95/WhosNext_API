using Microsoft.AspNetCore.Mvc;
using WhosNext_Dto.Response;

namespace WhosNext_API.Controllers.Base
{
    public class BaseController : ControllerBase
    {
        protected ErrorResponseBaseDto CreateObjectError(string message)
        {
            return new ErrorResponseBaseDto()
            {
                Message = message
            };
        }
    }
}
