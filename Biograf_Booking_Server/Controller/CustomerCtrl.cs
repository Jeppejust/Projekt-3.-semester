using Biograf_Booking_Server.Database;
using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Controller
{
    class CustomerCtrl
    {
        private ICustomerRepository<Customer> ICustRepo = null;
        public CustomerCtrl()
        {
            ICustRepo = new CustomerRepository();
        }
        public List<Customer> GetCustomers()
        {
            return ICustRepo.GetCustomers();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
