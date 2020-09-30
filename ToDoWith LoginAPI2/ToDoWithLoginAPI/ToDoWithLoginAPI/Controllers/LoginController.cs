using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ToDoWithLoginAPI.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoWithLoginAPI.Misc;

namespace ToDoWithLoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private IConfiguration _config;
        private readonly ToDoWithLoginAPIContext _context;

        public LoginController(IConfiguration config, ToDoWithLoginAPIContext context)
        {
            _config = config;
            _context = context;

        }
        [AllowAnonymous]
        [HttpPost]
        public async  Task<IActionResult> Login([FromBody]UserModel login)
        {
            IActionResult response = Unauthorized();
            var user = await  AuthenticateUser(login);

            if (user != null)
            {
                var tokenString =  GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        private string GenerateJSONWebToken(UserModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private async Task<UserModel> AuthenticateUser(UserModel login)
        {
            UserModel user = null;

            //Validate the User Credentials
            List<Users> usersList = await _context.Users.ToListAsync();
            Users users = usersList.Where(e => e.EmailAddress == login.EmailAddress).FirstOrDefault();
            if(users != null)
            {
                UsersDTO usersDTO = users.ToDTO();
                if(usersDTO.Password == login.Password)
                {
                    user = new UserModel { Username = usersDTO.Name, EmailAddress = usersDTO.EmailAddress };
                }
            }


            return user;
        }
    }
}