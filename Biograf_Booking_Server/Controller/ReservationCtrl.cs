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
            bool HasConflict = false;
            bool Inserted = false;
            if (r.Seats==null)
            {
                HasConflict = true;
            }
            HasConflict = CheckSeats(r.Seats);
            if (HasConflict == false)
            {
                bool Ins = IResRepo.InsertReservation(r);
                if (Ins==true)
                {
                    int rId = IResRepo.FindMaxRes();
                    ISeatRepo.UpdateSeats(r.Seats,rId);
                    Inserted = true;
                }
            }

            return Inserted;
        }
        public bool CheckSeats (List<Seat> s)
        {
            bool HasConflict = false;
            List<Seat> tempSeats = ISeatRepo.FindSeatsBySeatId(s);
            foreach (Seat tempS in s)
            {
                if (tempS.Booked==true)
                {
                    HasConflict = true;
                }
            }
            return HasConflict;
        }
    }
}
