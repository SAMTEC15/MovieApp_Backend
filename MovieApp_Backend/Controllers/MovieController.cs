using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp_Backend.Services;

namespace MovieApp_Backend.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MovieController : ControllerBase
	{
		private readonly IOmdbService _omdbService;

		public MovieController(IOmdbService omdbService)
		{
			_omdbService = omdbService;
		}

		[HttpGet("search")]
		public async Task<IActionResult> SearchMovies([FromQuery] string title)
		{
			var searchResults = await _omdbService.SearchMoviesAsync(title);

			return Ok(searchResults);
		}


		[HttpGet("{imdbId}")]
		public async Task<IActionResult> GetMovieDetails(string imdbId)
		{
			var movieDetails = await _omdbService.GetMovieDetailsAsync(imdbId);
			return Ok(movieDetails);
		}

	}

}
