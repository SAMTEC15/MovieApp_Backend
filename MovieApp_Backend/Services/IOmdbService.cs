using MovieApp_Backend.Models;

namespace MovieApp_Backend.Services
{
    public interface IOmdbService
    {
        Task<OmdbMovieDetailsResponse> GetMovieDetailsAsync(string imdbId);
        Task<OmdbSearchResponse> SearchMoviesAsync(string title);
    }
}
