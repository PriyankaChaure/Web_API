using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StatusCodeEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringAPIController : ControllerBase
    {
        [HttpGet]
        public string GetString()
        {
            return "Get String Called!";
        }

        [HttpPost]
        public string PostString()
        {
            return "Post String Called!";
        }

        [HttpPut]
        public string PutString()
        {
            return "Put String Called!";
        }

        [HttpDelete]
        public string DeleteString()
        {
            return "Delete String Called!";
        }
    }
}
