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
        public List<Movie> GetMovies()
        {
            return movieService.GetMovies();
        }
    }
}
