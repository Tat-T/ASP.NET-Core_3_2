using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Cinema.DataAccess;
using Cinema.Models;

namespace CinemaScheduleApp.Pages;

public class MovieDetailsModel : PageModel
{
    private readonly IMovieRepository _movieRepository;

    public Movie? Movie { get; set; }

    public MovieDetailsModel(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public IActionResult OnGet(string title)
    {
        // Получаем фильм по названию
        Movie = _movieRepository.GetAllMovies()
                                .FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        
        if (Movie == null)
        {
            // Если фильм не найден, возвращаем 404
            return NotFound();
        }

        return Page();
    }
}
