using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public string GetValues()
        {
            return "Get Values Called!";
        }

        [HttpPost]
        public string PostValues()
        {
            return "Post Values Called!";
        }

        [HttpPut]
        public string PutValues()
        {
            return "Put Values Called!";
        }

        [HttpDelete]
        public string DeleteVales()
        {
            return "Delete Values Called!";
        }
    }
}
