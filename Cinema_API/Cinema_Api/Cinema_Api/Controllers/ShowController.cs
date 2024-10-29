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
	public class ShowController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public ShowController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<Show> GetAllShow()
		{
			return _repoWrapper.Show.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Show>> GetShow(int id)
		{
			var Show = await _repoWrapper.Show.FindByCondition(e => e.ShowID == id).FirstOrDefaultAsync();
			if (Show == null)
			{
				return NotFound();
			}
			return Show;
		}

		[HttpPut("{id}")]
		public IActionResult PutShow(int id, Show Show)
		{
			if (id != Show.ShowID)
			{
				return BadRequest();
			}

			_repoWrapper.Show.Update(Show);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ShowExists(id))
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
		public ActionResult<Show> PostShow(Show Show)
		{
			_repoWrapper.Show.Create(Show);
			_repoWrapper.Save();
			return CreatedAtAction("GetShow", new { id = Show.ShowID }, Show);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteShow(int id)
		{
			var Show = await _repoWrapper.Show.FindByCondition(e => e.ShowID == id).FirstOrDefaultAsync();
			if (Show == null)
			{
				return NotFound();
			}
			_repoWrapper.Show.Delete(Show);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool ShowExists(int id)
		{
			return _repoWrapper.Show.FindByCondition(e => e.ShowID == id).Any(e => e.ShowID == id);
		}
	}
}
