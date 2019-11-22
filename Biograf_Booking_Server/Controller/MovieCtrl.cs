using Biograf_Booking_Server.Database;
using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Controller
{
    class MovieCtrl
    {
        private IMovieRepository<Movie> IMovRepo = null;
        public MovieCtrl()
        {
            IMovRepo = new MovieRepository();
        }

        public List<Movie> GetMovies()
        {
            return IMovRepo.GetMovies();
        }
    }
}
