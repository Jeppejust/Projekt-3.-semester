using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Biograf_Booking_Server.Database
{
    class CustomerRepository : ICustomerRepository<Customer>
    {
        private IDbConnection con = null;
        public List<Customer> GetCustomers()
        {
            string sqlGetAllCustomers = "select * from tblCustomer";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                List<Customer> Customers = new List<Customer>();
                con.Open();

                Customers = con.Query<Customer>(sqlGetAllCustomers).ToList();
                return Customers;
            }
        }

       
    }
}
