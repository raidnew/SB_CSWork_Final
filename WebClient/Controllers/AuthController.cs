using CSFinal_WebClient.Auth;
using CSFinal_WebClient.Models;
using CSWorkFinal_WebClient.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CSFinal_WebClient.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private AuthConnector _authConnector;

        public AuthController(ILogger<AuthController> logger)
        {
            _authConnector = new AuthConnector();
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {
            return View(new UserLoginData() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public IActionResult Login(UserLoginData authData)
        {
            _authConnector.Login(authData);
            return View(authData);
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
