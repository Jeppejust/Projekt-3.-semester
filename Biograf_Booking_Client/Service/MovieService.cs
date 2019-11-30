
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
        public List<Movie> GetAllMovies()
        {
            using(PersonServiceClient proxy = new PersonServiceClient())
            {
                return proxy.GetAllMovies();
            }
        }
        public Movie GetMovie(int id)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                return proxy.GetMovie(id);
            }
        }
    }
}
