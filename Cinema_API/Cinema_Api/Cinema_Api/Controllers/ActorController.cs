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
	public class ActorController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public ActorController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<Actor> GetAllActor()
		{
			return _repoWrapper.Actor.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Actor>> GetActor(int id)
		{
			var Actor = await _repoWrapper.Actor.FindByCondition(e => e.ActorID == id).FirstOrDefaultAsync();
			if (Actor == null)
			{
				return NotFound();
			}
			return Actor;
		}

		[HttpPut("{id}")]
		public IActionResult PutActor(int id, Actor Actor)
		{
			if (id != Actor.ActorID)
			{
				return BadRequest();
			}

			_repoWrapper.Actor.Update(Actor);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ActorExists(id))
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
		public ActionResult<Actor> PostActor(Actor Actor)
		{
			_repoWrapper.Actor.Create(Actor);
			_repoWrapper.Save();
			return CreatedAtAction("GetActor", new { id = Actor.ActorID }, Actor);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteActor(int id)
		{
			var Actor = await _repoWrapper.Actor.FindByCondition(e => e.ActorID == id).FirstOrDefaultAsync();
			if (Actor == null)
			{
				return NotFound();
			}
			_repoWrapper.Actor.Delete(Actor);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool ActorExists(int id)
		{
			return _repoWrapper.Actor.FindByCondition(e => e.ActorID == id).Any(e => e.ActorID == id);
		}
	}
}
