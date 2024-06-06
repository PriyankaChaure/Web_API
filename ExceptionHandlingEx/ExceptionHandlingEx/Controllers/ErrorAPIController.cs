using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlingEx.Controllers
{
    [ApiController]
    public class ErrorAPIController : ControllerBase
    {

        [HttpGet("error")]
        public IActionResult GetError()
        {
            var cntx = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var message = cntx.Error.Message +" "+ cntx.Path;
            //return Problem("We are facing some Problem Try Again!");
            return Problem(message);
        }
    }
}
