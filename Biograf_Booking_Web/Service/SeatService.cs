using Biograf_Booking_Web.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biograf_Booking_Web.Service
{
    public class SeatService
    {
        public List<Models.Seat> FindSeatsByHallId(int hId)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                List<Models.Seat> seats = new List<Models.Seat>();
                List<WebService.Seat> s = proxy.FindSeatsByHallId(hId);
                foreach (WebService.Seat tempS in s)
                {
                    Models.Seat seat = new Models.Seat();
                    seat.SeatId = tempS.SeatId;
                    seat.Row = tempS.Row;
                    seat.ResId = tempS.ResId;
                    seat.Number = tempS.Number;
                    seat.HallId = tempS.HallId;
                    seat.booked = tempS.Booked;
                    seats.Add(seat);
                }
                return seats;

            }
        }
    }
}