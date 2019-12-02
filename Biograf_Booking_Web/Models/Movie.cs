using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Web.Models
{
    public class Movie
    {
        
        public string Title { get; set; }

        public string Resume { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime PremiereDate { get; set; }

        public string Genre { get; set; }

        public int MovieId { get; set; }

        public int MovieLength { get; set; }
        public string ImagePath { get; set; }

    }
}
