using System;
using System.Numerics;
using Movies.Interfaces;
using Movies.Models;

namespace Movies.Services
{
    public class MovieServices:Imovie
    {
        public static List<Movie> list = new List<Movie>();
        public void AddMovie(Movie Movie)
        {
            list.Add(Movie);
        }

        public void DeleteMovie(int MovieId)
        {
            Movie Movie = list.SingleOrDefault(i => i.MovieId == MovieId);
            list.Remove(Movie);
        }

        public Movie GetMovieById(int MovieId)
        {
            Movie Movie = list.SingleOrDefault(i => i.MovieId == MovieId);
            return Movie;
        }

        public List<Movie> GetMovies()
        {
            return list;
        }

        public void UpdateMovie(Movie Movie)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[0].MovieId == Movie.MovieId)
                {
                    list[0].MovieName = Movie.MovieName;
                    list[0].Director = Movie.Director;
                    list[0].Lang = Movie.Lang;
                    list[0].Actor = Movie.Actor;
                    list[0].ReleaseYear = Movie.ReleaseYear;
                    break;
                }
            }
        }
        public Movie GetMovieByActor(String Actor)
        {
            Movie Movie = list.SingleOrDefault(i => i.Actor == Actor);
            return Movie;
        }
        public Movie GetMovieByLang(String Lang)
        {
            Movie Movie = list.SingleOrDefault(i => i.Lang == Lang);
            return Movie;
        }
        public Movie GetMovieByDirector(String Director)
        {
            Movie Movie = list.SingleOrDefault(i => i.Director == Director);
            return Movie;
        }

    }
}
