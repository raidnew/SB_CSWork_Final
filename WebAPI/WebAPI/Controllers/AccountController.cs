using CSFinal.Auth;
using CSFinal.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CSFinal_WebAPI.Controllers
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
                issuer: "CSFinalAPI",
                audience: "CSFinal",
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
