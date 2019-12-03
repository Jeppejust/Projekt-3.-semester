using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Biograf_Booking_Web.WebService;

namespace Biograf_Booking_Web.Service
{
    public class ReservationService
    {
        private PersonServiceClient proxy = new PersonServiceClient();
        public bool InsertReservation(Models.Reservation r)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                Reservation res = new Reservation();
                res.ReservationId = r.ReservationId;
                res.MovieId = r.MovieId;
                res.Date = r.Date;
                res.Seats = new List<Seat>();

                foreach (Models.Seat s in r.Seats)
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