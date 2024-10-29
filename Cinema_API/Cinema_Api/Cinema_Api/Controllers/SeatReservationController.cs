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
	public class SeatReservationController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public SeatReservationController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<SeatReservation> GetAllSeatReservation()
		{
			return _repoWrapper.SeatReservation.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<SeatReservation>> GetSeatReservation(int id)
		{
			var SeatReservation = await _repoWrapper.SeatReservation.FindByCondition(e => e.SeatReservationID == id).FirstOrDefaultAsync();
			if (SeatReservation == null)
			{
				return NotFound();
			}
			return SeatReservation;
		}

		[HttpPut("{id}")]
		public IActionResult PutSeatReservation(int id, SeatReservation SeatReservation)
		{
			if (id != SeatReservation.SeatReservationID)
			{
				return BadRequest();
			}

			_repoWrapper.SeatReservation.Update(SeatReservation);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!SeatReservationExists(id))
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
		public ActionResult<SeatReservation> PostSeatReservation(SeatReservation SeatReservation)
		{
			_repoWrapper.SeatReservation.Create(SeatReservation);
			_repoWrapper.Save();
			return CreatedAtAction("GetSeatReservation", new { id = SeatReservation.SeatReservationID }, SeatReservation);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteSeatReservation(int id)
		{
			var SeatReservation = await _repoWrapper.SeatReservation.FindByCondition(e => e.SeatReservationID == id).FirstOrDefaultAsync();
			if (SeatReservation == null)
			{
				return NotFound();
			}
			_repoWrapper.SeatReservation.Delete(SeatReservation);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool SeatReservationExists(int id)
		{
			return _repoWrapper.SeatReservation.FindByCondition(e => e.SeatReservationID == id).Any(e => e.SeatReservationID == id);
		}
	}
}
