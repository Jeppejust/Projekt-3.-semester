using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biograf_Booking_Server.Database;
using Biograf_Booking_Server.Model;

namespace Biograf_Booking_Server.Controller
{
    class HallCtrl
    {
        private IHallRepository<Hall> IHallRepo = null;
        public HallCtrl()
        {
            IHallRepo = new HallRepository();
        }
        public List<Hall> FindHalls(int id)
        {
            return IHallRepo.FindHalls(id);
        }
    }
}
