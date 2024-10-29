using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Contracts;
using DomainModelEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Cinema_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserTokenController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		private IConfiguration _configuration;
		public UserTokenController(IConfiguration configuration, IRepositoryWrapper repoWrapper)
		{
			_configuration = configuration;
			_repoWrapper = repoWrapper;
		}

		[HttpPost]
		public async Task<IActionResult> Post(User userInfo)
		{
			if (userInfo != null && userInfo.Username != null && userInfo.Password != null)
			{
				//Member
				var user = await GetAdmin(userInfo.Username, userInfo.Password);

				if (user.Value != null)
				{
					var claim = new[] {
					new Claim(JwtRegisteredClaimNames.Sub,_configuration["Jwt:Subject"]),
					new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
					new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
					new Claim("UserId",user.Value.UserID.ToString()),
					new Claim("Username",user.Value.Username),
					new Claim("Password",user.Value.Password)
					};
					var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
					var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
					var token = new JwtSecurityToken(
						_configuration["Jwt:Issuer"],
						_configuration["Jwt:Audience"],
						claim,
						expires: DateTime.Now.AddMinutes(20),
						signingCredentials: signIn
						);
					return Ok(new JwtSecurityTokenHandler().WriteToken(token));
				}
				else
				{
					return BadRequest("Invalid credentials");
				}
			}
			else
			{
				return BadRequest();
			}
		}

		[HttpGet]
		public async Task<ActionResult<User>> GetAdmin(string Username, string Password)
		{
			return await _repoWrapper.User.FindByCondition(e => e.Username == Username && e.Password == Password).FirstOrDefaultAsync();
		}
	}
}
