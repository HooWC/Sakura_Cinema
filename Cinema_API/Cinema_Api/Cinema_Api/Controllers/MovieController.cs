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
	public class MovieController : ControllerBase
	{
		private IRepositoryWrapper _repoWrapper;
		public MovieController(IRepositoryWrapper repoWrapper)
		{
			_repoWrapper = repoWrapper;
		}

		[HttpGet]
		public IEnumerable<Movie> GetAllMovie()
		{
			return _repoWrapper.Movie.FindAll();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Movie>> GetMovie(int id)
		{
			var Movie = await _repoWrapper.Movie.FindByCondition(e => e.MovieID == id).FirstOrDefaultAsync();
			if (Movie == null)
			{
				return NotFound();
			}
			return Movie;
		}

		[HttpPut("{id}")]
		public IActionResult PutMovie(int id, Movie Movie)
		{
			if (id != Movie.MovieID)
			{
				return BadRequest();
			}

			_repoWrapper.Movie.Update(Movie);

			try
			{
				_repoWrapper.Save();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!MovieExists(id))
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
		public ActionResult<Movie> PostMovie(Movie Movie)
		{
			_repoWrapper.Movie.Create(Movie);
			_repoWrapper.Save();
			return CreatedAtAction("GetMovie", new { id = Movie.MovieID }, Movie);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteMovie(int id)
		{
			var Movie = await _repoWrapper.Movie.FindByCondition(e => e.MovieID == id).FirstOrDefaultAsync();
			if (Movie == null)
			{
				return NotFound();
			}
			_repoWrapper.Movie.Delete(Movie);
			_repoWrapper.Save();
			return NoContent();
		}

		private bool MovieExists(int id)
		{
			return _repoWrapper.Movie.FindByCondition(e => e.MovieID == id).Any(e => e.MovieID == id);
		}
	}
}
