using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Biograf_Booking_Web.WebService;

namespace Biograf_Booking_Web.Service
{
    public class MovieService
    {
        public List<Movie> GetMovies()
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                return proxy.GetAllMovies();
            }
        }
    }
}