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
	public class ReservationController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public ReservationController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<Reservation> GetAllReservation()
		{
			return _repoWrapper.Reservation.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Reservation>> GetReservation(int id)
		{
			var Reservation = await _repoWrapper.Reservation.FindByCondition(e => e.ReservationID == id).FirstOrDefaultAsync();
			if (Reservation == null)
			{
				return NotFound();
			}
			return Reservation;
		}

		[HttpPut("{id}")]
		public IActionResult PutReservation(int id, Reservation Reservation)
		{
			if (id != Reservation.ReservationID)
			{
				return BadRequest();
			}

			_repoWrapper.Reservation.Update(Reservation);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ReservationExists(id))
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
		public ActionResult<Reservation> PostReservation(Reservation Reservation)
		{
			_repoWrapper.Reservation.Create(Reservation);
			_repoWrapper.Save();
			return CreatedAtAction("GetReservation", new { id = Reservation.ReservationID }, Reservation);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteReservation(int id)
		{
			var Reservation = await _repoWrapper.Reservation.FindByCondition(e => e.ReservationID == id).FirstOrDefaultAsync();
			if (Reservation == null)
			{
				return NotFound();
			}
			_repoWrapper.Reservation.Delete(Reservation);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool ReservationExists(int id)
		{
			return _repoWrapper.Reservation.FindByCondition(e => e.ReservationID == id).Any(e => e.ReservationID == id);
		}
	}
}
