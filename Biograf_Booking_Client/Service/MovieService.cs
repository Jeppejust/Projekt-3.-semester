using Biograf_Booking_Client.Model;
using Biograf_Booking_Client.WCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Service
{
    class MovieService
    {
        public List<Movie> GetMovies()
        {
            PersonServiceClient proxy = new PersonServiceClient();
            return proxy.GetMovies();

        }
    }
}
