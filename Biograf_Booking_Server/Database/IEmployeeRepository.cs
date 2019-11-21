using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Database
{
    interface IEmployeeRepository<T> where T : class
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(int searchId);
        Employee LogOn(string user, string pass);
        string GetSaltFromEmployeeByUsername(string username);
    }
}
