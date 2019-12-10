using Biograf_Booking_Server.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace SelfHost_service_Bio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(PersonService));
                host.Open();
                Console.WriteLine("HIT ME!");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Console.ReadKey();
            }

        }
    }
}
