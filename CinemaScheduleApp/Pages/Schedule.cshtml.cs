using Microsoft.AspNetCore.Mvc.RazorPages;
using Cinema.DataAccess;
using Cinema.Models;

namespace CinemaScheduleApp.Pages;

public class ScheduleModel : PageModel
{
    private readonly IMovieRepository _movieRepository;

    public List<Movie> Movies { get; set; } = new();
    public string? SearchQuery { get; set; }

    public ScheduleModel(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

   public void OnGet(string? searchQuery)
    {
        SearchQuery = searchQuery;

        var allMovies = _movieRepository.GetAllMovies();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            Movies = allMovies
                .Where(movie =>
                    movie.Title.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    movie.Director.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    movie.Genre.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    movie.Description.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    movie.ShowTimes.Any(time => time.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();
        }
        else
        {
            Movies = (List<Movie>)allMovies;
        }
    }
}
