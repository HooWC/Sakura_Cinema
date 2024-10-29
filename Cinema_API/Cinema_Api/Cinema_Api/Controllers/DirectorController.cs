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
	public class DirectorController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public DirectorController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<Director> GetAllDirector()
		{
			return _repoWrapper.Director.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Director>> GetDirector(int id)
		{
			var Director = await _repoWrapper.Director.FindByCondition(e => e.DirectorID == id).FirstOrDefaultAsync();
			if (Director == null)
			{
				return NotFound();
			}
			return Director;
		}

		[HttpPut("{id}")]
		public IActionResult PutDirector(int id, Director Director)
		{
			if (id != Director.DirectorID)
			{
				return BadRequest();
			}

			_repoWrapper.Director.Update(Director);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!DirectorExists(id))
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
		public ActionResult<Director> PostDirector(Director Director)
		{
			_repoWrapper.Director.Create(Director);
			_repoWrapper.Save();
			return CreatedAtAction("GetDirector", new { id = Director.DirectorID }, Director);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteDirector(int id)
		{
			var Director = await _repoWrapper.Director.FindByCondition(e => e.DirectorID == id).FirstOrDefaultAsync();
			if (Director == null)
			{
				return NotFound();
			}
			_repoWrapper.Director.Delete(Director);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool DirectorExists(int id)
		{
			return _repoWrapper.Director.FindByCondition(e => e.DirectorID == id).Any(e => e.DirectorID == id);
		}
	}
}
