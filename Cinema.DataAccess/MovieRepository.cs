using Cinema.Models;

namespace Cinema.DataAccess;

public class MovieRepository : IMovieRepository
{
    private List<Movie> _movies = new()
    {
        new Movie
        {
            Title = "Интерстеллар",
            Director = "Кристофер Нолан",
            Genre = "Фантастика",
            Description = "Фильм о космических путешествиях и времени.",
            ShowTimes = new List<string> { "10:00", "14:30", "18:00", "21:30" }
        },
        new Movie
        {
            Title = "Аватар",
            Director = "Джеймс Кэмерон",
            Genre = "Фантастика",
            Description = "Фантастический мир Пандоры.",
            ShowTimes = new List<string> { "11:00", "15:00", "19:00", "22:00" }
        }
    };

    public IEnumerable<Movie> GetAllMovies()
    {
        return _movies;
    }
}
