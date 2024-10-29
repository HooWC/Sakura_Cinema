using Contracts;
using DomainModelEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PaymentController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public PaymentController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<Payment> GetAllPayment()
		{
			return _repoWrapper.Payment.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Payment>> GetPayment(int id)
		{
			var Payment = await _repoWrapper.Payment.FindByCondition(e => e.PaymentID == id).FirstOrDefaultAsync();
			if (Payment == null)
			{
				return NotFound();
			}
			return Payment;
		}

		[HttpPut("{id}")]
		public IActionResult PutPayment(int id, Payment Payment)
		{
			if (id != Payment.PaymentID)
			{
				return BadRequest();
			}

			_repoWrapper.Payment.Update(Payment);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!PaymentExists(id))
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
		public ActionResult<Payment> PostPayment(Payment Payment)
		{
			_repoWrapper.Payment.Create(Payment);
			_repoWrapper.Save();
			return CreatedAtAction("GetPayment", new { id = Payment.PaymentID }, Payment);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeletePayment(int id)
		{
			var Payment = await _repoWrapper.Payment.FindByCondition(e => e.PaymentID == id).FirstOrDefaultAsync();
			if (Payment == null)
			{
				return NotFound();
			}
			_repoWrapper.Payment.Delete(Payment);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool PaymentExists(int id)
		{
			return _repoWrapper.Payment.FindByCondition(e => e.PaymentID == id).Any(e => e.PaymentID == id);
		}
	}
}
