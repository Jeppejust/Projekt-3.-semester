using Biograf_Booking_Client.PersonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Service
{
    class ReservationService
    {
        public bool InsertReservation(Model.Reservation r)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                Reservation res = new Reservation();
                res.ReservationId = r.ReservationId;
                res.MovieId = r.MovieId;
                res.CustomerId = r.CustomerId;
                res.Seats = new List<Seat>();
                foreach (Model.Seat s in r.Seats)
                {
                    Seat seat = new Seat();
                    seat.HallId = s.HallId;
                    seat.Number = s.Number;
                    seat.ResId = s.ResId;
                    seat.Row = s.Row;
                    seat.SeatId = s.SeatId;
                    res.Seats.Add(seat);
                }

                return proxy.InsertReservation(res);
            }
        }
    }
}
