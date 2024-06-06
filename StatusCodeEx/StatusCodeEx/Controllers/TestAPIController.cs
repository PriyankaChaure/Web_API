using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StatusCodeEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetStatus(int id)
        {
            switch (id)
            {
                case 1:
                    return NotFound();
                    break;
                case 2:
                    return Created("http://www.demo.com",new { });
                    break;
                case 3:
                    return Unauthorized();
                    break;
                case 4:
                        return Ok();
                    break;
                case 5:
                    return BadRequest();
                    break;
                default:
                    return StatusCode(501);
                    break;

            }
        }
    }
}
