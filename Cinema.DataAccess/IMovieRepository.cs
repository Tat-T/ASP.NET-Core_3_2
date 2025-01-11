namespace Cinema.DataAccess;

using Cinema.Models;

public interface IMovieRepository
{
    IEnumerable<Movie> GetAllMovies();
}
