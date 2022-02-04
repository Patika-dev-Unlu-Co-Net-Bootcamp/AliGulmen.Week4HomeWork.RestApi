using AliGulmen.Week4.HomeWork.RestfulApi.Attributes;
using AliGulmen.Week4.HomeWork.RestfulApi.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class AccountController : ControllerBase
    {


        private readonly TokenGenerator _tokenGenerator; 
        public AccountController(TokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
        }


        [HttpPost]
        public Token Login([FromBody] User user)
        {
            Token token = new Token();

            if (user.PasswordHash == "1" && user.Email == "a@a.com")
            {
                token = _tokenGenerator.CreateToken(user);
            }

            return token;
        }


        //[HttpGet]
        //[CustomPermission("admin")]
        //public IActionResult IsLoggedIn(string username, string password)
        //{
        //    var pass = "1234";

        //    var permissions = typeof(AccountController)
        //        .GetMethod("IsLoggedIn")
        //        .GetCustomAttributes(typeof(CustomPermissionAttribute), true)
        //        .Cast<CustomPermissionAttribute>()
        //        .Select(attribute => attribute.Permission).ToArray();

        //    if(permissions.Any(parameter => parameter == username) && password == pass)
        //    return Ok();
        //    return Unauthorized();
        //}



    }
}
