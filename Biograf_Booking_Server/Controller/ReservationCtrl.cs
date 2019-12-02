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
        private ISeatRepository<Seat> ISeatRepo = null;

        public ReservationCtrl()
        {
            IResRepo = new ReservationRepository();
            ISeatRepo = new SeatRepository();
        }

        public List<Reservation> FindAllReservations()
        {
            return IResRepo.FindAllReservations() ;
        }
        public Reservation FindReservationById(int Id)
        {
            return IResRepo.FindReservationById(Id);
        }
        public bool InsertReservation(Reservation r)
        {
            bool Inserted = false;
            bool HasConflict = CheckSeats(r.Seats);
            if (!HasConflict)
            {
                Inserted = IResRepo.InsertReservation(r);
            }
            else {
                Inserted = false;
            }
            return Inserted;
        }
        public bool CheckSeats (List<Seat> s)
        {
            bool HasConflict = false;
            List<Seat> tempSeats = ISeatRepo.FindSeatsBySeatId(s);
            foreach (Seat tempS in s)
            {
                if (tempS.ResId != null || tempS.ResId == 0)
                {
                    HasConflict = true;
                }
            }
            return HasConflict;
        }
    }
}
