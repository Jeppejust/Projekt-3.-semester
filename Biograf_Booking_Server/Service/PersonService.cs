using Biograf_Booking_Server.Controller;
using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class PersonService : IPersonService
    {
        private EmployeeCtrl EmpCtrl = new EmployeeCtrl();
        private CustomerCtrl CustCtrl = new CustomerCtrl();
        private MovieCtrl MovCtrl = new MovieCtrl();

        //[OperationBehavior(TransactionScopeRequired = true)]
        public List<Customer> GetCustomers()
        {
            return CustCtrl.GetCustomers();
        }

        public List<Employee> GetEmployees()
        {
            return EmpCtrl.GetEmployees();
        }

        public Employee GetEmployeeById(int SearchId)
        {
            return EmpCtrl.GetEmployeeById(SearchId);
        }

        public bool LogOn(string user, string pass)
        {
            return EmpCtrl.ComparePassword(user,pass);
        }
        public List<Movie> GetMovies()
        {
            return MovCtrl.GetMovies();
        }
    }
}
