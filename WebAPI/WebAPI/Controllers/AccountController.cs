using CSWork21.Auth;
using CSWork21_WebAPI.Auth;
using CSWork21_WebAPI.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{

    /**
     {
        "name":"aaa",
        "password":"sdff"
    }
    */

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        [AllowAnonymous]
        public ActionResult<string> Post(
    AuthenticationRequest authRequest,
    [FromServices] IJwtSigningEncodingKey signingEncodingKey)
        {
            var claims = new Claim[]
            {
            new Claim(ClaimTypes.NameIdentifier, authRequest.Name)
            };

            var token = new JwtSecurityToken(
                issuer: "CSWork21API",
                audience: "CSWork21",
                claims: claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: new SigningCredentials(
                        signingEncodingKey.GetKey(),
                        signingEncodingKey.SigningAlgorithm)
            );

            string jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
    }
}
