using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ExceptionHandlingEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathAPIController : ControllerBase
    {

        [HttpGet("{a}/{b}")]
        public IActionResult GetDivision(int a, int b)
        {
            int c= a / b;
            return Ok(c);
        }   
    }
}
