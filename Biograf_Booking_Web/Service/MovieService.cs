using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Biograf_Booking_Web.WebService;


namespace Biograf_Booking_Web.Service
{
    public class MovieService
    {
        public List<Models.Movie> GetMovies()
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                List<Models.Movie> movies = new List<Models.Movie>();
                List<Movie> mS = proxy.GetAllMovies();
                foreach (Movie m in mS)
                {
                    Models.Movie movie = new Models.Movie();
                    movie.MovieId = m.MovieId;
                    movie.MovieLength = m.MovieLength;
                    movie.PremiereDate = m.PremiereDate;
                    movie.Resume = m.Resume;
                    movie.Title = m.Title;
                    movie.ImagePath = "/"  + m.ImagePath;
                    movie.Genre = m.Genre;
                    movies.Add(movie);
                }
                return movies;
            }
        }

        public Models.Movie GetMovie(int id)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                Movie m = proxy.GetMovie(id);
                Models.Movie movie = new Models.Movie();
                movie.MovieId = m.MovieId;
                movie.MovieLength = m.MovieLength;
                movie.PremiereDate = m.PremiereDate;
                movie.Resume = m.Resume;
                movie.Title = m.Title;
                movie.ImagePath = "/" + m.ImagePath;
                movie.Genre = m.Genre;
                return movie;
            }
        }
    }
}