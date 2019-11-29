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
        public List<Seat> FindSeatsByHallId(int hId)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                List<Model.Seat> seats = new List<Model.Seat>();
                List<Seat> s = proxy.FindSeatsByHallId(hId);
                foreach (Seat tempS in s)
                {
                    Model.Seat seat = new Model.Seat();
                    seat.seatId = tempS.seatId;
                    seat.row = tempS.row;
                    seat.ResId = tempS.ResId;
                    seat.number = tempS.number;
                    seat.hallId = tempS.hallId;
                    seats.Add(seat);
                }
                return seats;
                
            }
        }
    }
}
