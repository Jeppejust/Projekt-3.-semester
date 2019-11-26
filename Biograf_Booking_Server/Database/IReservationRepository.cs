using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Database
{
    interface IReservationRepository<T> where T : class
    {
        List<Reservation> FindAllReservations();
        Reservation FindReservationById(int Id);
        void InsertReservation(Reservation r);
    }
}
