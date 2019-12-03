using Biograf_Booking_Client.Model;
using Biograf_Booking_Client.PersonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biograf_Booking_Client.Service
{
    class SeatService
    {
        public List<Model.Seat> FindSeatsByHallId(int hId)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                List<Model.Seat> seats = new List<Model.Seat>();
                List<PersonService.Seat> s = proxy.FindSeatsByHallId(hId);
                foreach (PersonService.Seat tempS in s)
                {
                    Model.Seat seat = new Model.Seat();
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
