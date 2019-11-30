using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Model
{
    public class Movie
    {

        public string Title { get; set; }
        
        public string Resume { get; set; }
        
        public DateTime PremiereDate { get; set; }
        public string Genre { get; set; }
        
        public string Instructor { get; set; }
        
        public int MovieId { get; set; }
        
        public int MovieLength { get; set; }
        
        public string ImagePath { get; set; }
    }
}
