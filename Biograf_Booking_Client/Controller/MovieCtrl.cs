using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biograf_Booking_Client.Model;
using Biograf_Booking_Client.Service;


namespace Biograf_Booking_Client.Controller
{
    class MovieCtrl
    {
        MovieService movieService = new MovieService();
        public List<Movie> GetAllMovies()
        {
            return movieService.GetAllMovies();
        }
        public Movie GetMovieById(int id)
        {
            return movieService.GetMovie(id);
        }
        public List<Hall> FindHalls(int hId)
        {
            return movieService.FindHalls(hId);
        }
    }

}
