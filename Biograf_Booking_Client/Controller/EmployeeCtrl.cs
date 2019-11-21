using Biograf_Booking_Client.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Client.Controller
{
    class EmployeeCtrl
    {
        private EmployeeService empSer = null;
        public EmployeeCtrl()
        {
            empSer = new EmployeeService();
        }
        public bool Login(string username, string password)
        {
            bool b = empSer.Login(username, password);
            return b;
        }
    }
}
