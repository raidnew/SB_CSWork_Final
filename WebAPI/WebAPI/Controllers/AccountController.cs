using CSWork21.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        [HttpGet]
        [Route("login/{returnUrl}")]
        public string Login(string returnUrl)
        {
            return "11111111";
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<string> Login(UserLoginData authData)
        {
            return "aaaaaaaaaaa";
        }
    }
}
