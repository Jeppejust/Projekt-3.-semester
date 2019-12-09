using Biograf_Booking_Server.Database;
using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            
            if (r.Seats.Count<=0|| r.Seats==null)
            {
                HasConflict = true;
            }
            if (CheckSeatsForConflict(r.Seats) == true)
            {
                HasConflict = true;
            }
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
        public bool CheckSeatsForConflict(List<Seat> s)
        {
            bool HasConflict = false;
            List<Seat> tempSeats = ISeatRepo.FindSeatsBySeatId(s);
            foreach (Seat tempS in tempSeats)
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
