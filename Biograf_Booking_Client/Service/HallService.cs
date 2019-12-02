using Biograf_Booking_Client.PersonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Service
{
    class HallService
    {
        public List<Model.Hall> FindHalls(int mId)
        {
            using (PersonServiceClient proxy = new PersonServiceClient())
            {
                List<Hall> halls = proxy.FindHalls(mId);
                List<Model.Hall> mH = new List<Model.Hall>();
                foreach (Hall tempH in halls)
                {
                    Model.Hall h = new Model.Hall();
                    h.HallId = tempH.HallId;
                    h.MovieId = tempH.MovieId;
                    h.ShowDate = tempH.ShowDate;
                    h.ShowTime = tempH.ShowTime;
                    mH.Add(h);
                }              
                return mH;
            }
        }
    }
}
