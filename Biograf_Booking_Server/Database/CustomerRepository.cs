using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

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
        public Customer LogOn(string email, string pass)
        {
            string sqlGetAccount = "SELECT DISTINCT Email, Password FROM tblCustomer WHERE Email = @email AND Password = @pass";
            Customer cus = new Customer();
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                cus = con.Query<Customer>(sqlGetAccount, new { email, pass }).FirstOrDefault();
            }
            return cus;
        }
        public string GetSaltFromCustomerByEmail(string email)
        {
            string s="";
            string sqlGetSaltByEmail = "select * from tblCustomer where Email = @Email";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                con.Open();
                Customer cus = new Customer();
                
                try
                {
                    cus = con.Query<Customer>(sqlGetSaltByEmail, new { email }).FirstOrDefault();
                    if (cus.Salt == null)
                    {
                        s = "";
                    }
                    else
                    {
                        s = cus.Salt;
                    }
                    
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    s = "";                    
                }
                con.Close();
                con.Dispose();
                
            }
            return s;
        }
        public bool InsertCustomer(Customer c)
        {
            string SqlInsertCustomer = "insert into tblCustomer(FName, LName, PhoneNo, Email, PassWord, Salt) values (@FName, @LName, @phoneNo,@Email ,@PassWord ,@Salt)";
            bool inserted = false;
            using (con = new SqlConnection(DataBase.DbConnectionString))   
            {
                try
                {
                    con.Execute(SqlInsertCustomer, new { FName = c.FName, LName = c.LName, PhoneNo = c.PhoneNo, Email = c.Email, Password = c.Password, Salt = c.Salt });
                    inserted = true;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    inserted = false;
                }

                return inserted;
            }
        }
        public Customer GetCustomerByEmail(string email)
        {
            Customer c = new Customer();
            string SqlGetCustomerByEmail = "select * from tblCustomer where Email = @Email";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                try
                {
                    c = con.Query<Customer>(SqlGetCustomerByEmail, new { email }).Single();

                }
                catch (Exception)
                {

                    c = null;
                }
                
            }
            return c;
        }
    }
}
