using Biograf_Booking_Client.Model;
using Biograf_Booking_Client.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Controller
{
    class HallCtrl
    {
        public List<Hall> FindHalls (int mId)
        {
            HallService hallService = new HallService();
            return hallService.FindHalls(mId);
        }
    }
}
