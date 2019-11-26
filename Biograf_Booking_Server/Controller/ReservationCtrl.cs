using Biograf_Booking_Server.Database;
using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Controller
{
    class ReservationCtrl
    {
        private IReservationRepository<Reservation> IResRepo = null;

        public ReservationCtrl()
        {
            IResRepo = new ReservationRepository();
        }

        public List<Reservation> FindAllReservations()
        {
            return IResRepo.FindAllReservations() ;
        }
        public Reservation FindReservationById(int Id)
        {
            return IResRepo.FindReservationById(Id);
        }
        public void InsertReservation(Reservation r)
        {
            IResRepo.InsertReservation(r);
        }
    }
}
