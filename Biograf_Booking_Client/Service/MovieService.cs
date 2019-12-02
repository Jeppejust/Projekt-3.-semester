
using Biograf_Booking_Client.PersonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Service
{
    class MovieService
    {
        
        public List<Model.Movie> GetAllMovies()
        {
            using(PersonServiceClient proxy = new PersonServiceClient())
            {
                List<Model.Movie> movies = new List<Model.Movie>();
                List<Movie> mS = proxy.GetAllMovies();
                foreach (Movie m in mS)
                {
                    Model.Movie movie = new Model.Movie();
                    movie.MovieId = m.MovieId;
                    movie.MovieLength = m.MovieLength;
                    movie.PremiereDate = m.PremiereDate;
                    movie.Resume = m.Resume;
                    movie.Title = m.Title;
                    movie.ImagePath = m.ImagePath;
                    movie.Genre = m.Genre;
                    movies.Add(movie);
                }
                return movies;
            }
        }
        public Model.Movie GetMovie(int id)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                Movie m = proxy.GetMovie(id);
                Model.Movie movie = new Model.Movie();
                movie.MovieId = m.MovieId;
                movie.MovieLength = m.MovieLength;
                movie.PremiereDate = m.PremiereDate;
                movie.Resume = m.Resume;
                movie.Title = m.Title;
                movie.ImagePath = m.ImagePath;
                movie.Genre = m.Genre;
                return movie;
            }
        }

        internal List<Model.Hall> FindHalls(int movieId)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                List<Model.Hall> halls = new List<Model.Hall>();
                List<Hall> hS = proxy.FindHalls(movieId);
                foreach (Hall h in hS)
                {
                    Model.Hall hall = new Model.Hall();
                    hall.HallId = h.HallId;
                    hall.MovieId = h.MovieId;
                    hall.ShowTime = h.ShowTime;
                    
                    halls.Add(hall);
                }

                return halls;
            }
        }
    }
}
