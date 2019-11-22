using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Database
{
    interface IMovieRepository<T> where T : class
    {
        List<Movie> GetMovies();
    }
}
