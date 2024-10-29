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
	public class AdminController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public AdminController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<Admin> GetAllAdmin()
		{
			return _repoWrapper.Admin.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Admin>> GetAdmin(int id)
		{
			var Admin = await _repoWrapper.Admin.FindByCondition(e => e.AdminID == id).FirstOrDefaultAsync();
			if (Admin == null)
			{
				return NotFound();
			}
			return Admin;
		}

		[HttpPut("{id}")]
		public IActionResult PutAdmin(int id, Admin Admin)
		{
			if (id != Admin.AdminID)
			{
				return BadRequest();
			}

			_repoWrapper.Admin.Update(Admin);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!AdminExists(id))
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
		public ActionResult<Admin> PostAdmin(Admin Admin)
		{
			_repoWrapper.Admin.Create(Admin);
			_repoWrapper.Save();
			return CreatedAtAction("GetAdmin", new { id = Admin.AdminID }, Admin);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAdmin(int id)
		{
			var Admin = await _repoWrapper.Admin.FindByCondition(e => e.AdminID == id).FirstOrDefaultAsync();
			if (Admin == null)
			{
				return NotFound();
			}
			_repoWrapper.Admin.Delete(Admin);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool AdminExists(int id)
		{
			return _repoWrapper.Admin.FindByCondition(e => e.AdminID == id).Any(e => e.AdminID == id);
		}
	}
}
