using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Database
{
    interface IHallRepository<T> where T : class
    {
        List<Hall> FindHalls(int id);
    }
}
