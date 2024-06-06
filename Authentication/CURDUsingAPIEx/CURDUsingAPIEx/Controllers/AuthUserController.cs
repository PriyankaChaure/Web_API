using CURDUsingAPIEx.Models;
using CURDUsingAPIEx.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CURDUsingAPIEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthUserController : ControllerBase
    {
        CompanyContext cntx;
        public AuthUserController(CompanyContext tcntx)
        {
            this.cntx = tcntx;
        }
        [HttpPost]
        public IActionResult ValidateUser(LoginVM rec)
        {
            if (rec == null)
                return BadRequest();

            if (ModelState.IsValid)
            {
                var urec = this.cntx.Users.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
                if (urec != null)
                {
                    //generate token
                    //first delete any old tokens
                    var oldtokens = this.cntx.UserTokens.Where(p => p.UserID == urec.UserID);
                    foreach (var temp in oldtokens)
                    {
                        this.cntx.UserTokens.Remove(temp);
                    }
                    this.cntx.SaveChanges();

                    string token =Guid.NewGuid().ToString();
                    //save it
                    UserToken ut = new UserToken();
                    ut.UserID = urec.UserID;
                    ut.Token = token;
                    this.cntx.UserTokens.Add(ut);
                    this.cntx.SaveChanges();

                    //return it
                    return Ok(token);

                }
                else
                {
                    return Ok("Invalid Email Id or Password!");
                }

            }

            return BadRequest(rec);
        }
    }
}
