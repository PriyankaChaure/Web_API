using DataAPIContentNegotiationEx.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataAPIContentNegotiationEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataAPIController : ControllerBase
    {

        CompanyContext cc;
        public DataAPIController(CompanyContext tcc)
        {
            this.cc = tcc;
        }
        
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.cc.Products.ToList());
        }
    }
}
