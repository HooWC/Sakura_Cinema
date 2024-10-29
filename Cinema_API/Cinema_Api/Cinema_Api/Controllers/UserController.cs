using Contracts;
using DomainModelEntity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class UserController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public UserController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<User> GetAllUser()
		{
			return _repoWrapper.User.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<User>> GetUser(int id)
		{
			var User = await _repoWrapper.User.FindByCondition(e => e.UserID == id).FirstOrDefaultAsync();
			if (User == null)
			{
				return NotFound();
			}
			return User;
		}

		[HttpPut("{id}")]
		public IActionResult PutUser(int id, User User)
		{
			if (id != User.UserID)
			{
				return BadRequest();
			}

			_repoWrapper.User.Update(User);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!UserExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
			return NoContent();
		}

		[HttpPost]
		public ActionResult<User> PostUser(User User)
		{
			_repoWrapper.User.Create(User);
			_repoWrapper.Save();
			return CreatedAtAction("GetUser", new { id = User.UserID }, User);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUser(int id)
		{
			var User = await _repoWrapper.User.FindByCondition(e => e.UserID == id).FirstOrDefaultAsync();
			if (User == null)
			{
				return NotFound();
			}
			_repoWrapper.User.Delete(User);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool UserExists(int id)
		{
			return _repoWrapper.User.FindByCondition(e => e.UserID == id).Any(e => e.UserID == id);
		}
	}
}
