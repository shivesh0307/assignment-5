using Movies.Models;

namespace Movies.Interfaces
{
    public interface Imovie
    {
        List<Movie> GetMovies();
        Movie GetMovieById(int MovieId);
        Movie GetMovieByActor(String Actor);
        Movie GetMovieByLang(String Lang);
        Movie GetMovieByDirector(String Director);

        void AddMovie(Movie Movie);
        void DeleteMovie(int MovieId);
        void UpdateMovie(Movie Movie);
    }
}
