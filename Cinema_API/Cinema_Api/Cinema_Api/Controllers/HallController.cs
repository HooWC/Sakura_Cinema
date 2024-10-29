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
	public class HallController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public HallController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<Hall> GetAllHall()
		{
			return _repoWrapper.Hall.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Hall>> GetHall(int id)
		{
			var Hall = await _repoWrapper.Hall.FindByCondition(e => e.HallID == id).FirstOrDefaultAsync();
			if (Hall == null)
			{
				return NotFound();
			}
			return Hall;
		}

		[HttpPut("{id}")]
		public IActionResult PutHall(int id, Hall Hall)
		{
			if (id != Hall.HallID)
			{
				return BadRequest();
			}

			_repoWrapper.Hall.Update(Hall);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!HallExists(id))
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
		public ActionResult<Hall> PostHall(Hall Hall)
		{
			_repoWrapper.Hall.Create(Hall);
			_repoWrapper.Save();
			return CreatedAtAction("GetHall", new { id = Hall.HallID }, Hall);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteHall(int id)
		{
			var Hall = await _repoWrapper.Hall.FindByCondition(e => e.HallID == id).FirstOrDefaultAsync();
			if (Hall == null)
			{
				return NotFound();
			}
			_repoWrapper.Hall.Delete(Hall);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool HallExists(int id)
		{
			return _repoWrapper.Hall.FindByCondition(e => e.HallID == id).Any(e => e.HallID == id);
		}
	}
}
