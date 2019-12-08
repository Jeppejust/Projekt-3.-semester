﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Web.Models
{
    public class Seat
    {
        public int Number { get; set; }

        public int Row { get; set; }

        public int HallId { get; set; }

        public int SeatId { get; set; }

        public int ResId { get; set; }

        public string Color { get; set; }

        public bool booked { get; set; }
    }
}
