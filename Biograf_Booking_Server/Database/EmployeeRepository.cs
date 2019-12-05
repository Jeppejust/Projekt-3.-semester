using Biograf_Booking_Server.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Database
{
    class EmployeeRepository : IEmployeeRepository<Employee>
    {
        private IDbConnection con = null;

        public List<Employee> GetEmployees()
        {
            string sqlGetAllEmployees = "select * from tblEmployee";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                List<Employee> Employees = new List<Employee>();
                con.Open();

                Employees = con.Query<Employee>(sqlGetAllEmployees).ToList();
                con.Close();
                con.Dispose();
                return Employees;
            }
        }
        public Employee GetEmployeeById(int SearchId)
        {
            string sqlGetEmployeeById = "select * from tblEmployee where EmployeeId = @Id";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                con.Open();
                Employee emp = new Employee();
                emp = con.Query<Employee>(sqlGetEmployeeById, new { Id = SearchId }).FirstOrDefault();
                con.Close();
                con.Dispose();
                return emp;
            }
        }

        public Employee LogOn(string user, string pass)
        {
            string sqlGetAccount = "SELECT DISTINCT Username, Password, Salt FROM tblEmployee WHERE Username = @user AND Password = @pass";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                Employee emp = new Employee();
                emp = con.Query<Employee>(sqlGetAccount, new { user, pass }).FirstOrDefault();
                con.Close();
                con.Dispose();
                return emp;

            }

        }
        public string GetSaltFromEmployeeByUsername(string username)
        {
            string s="";
            string sqlGetEmployeeByUsername = "select * from tblEmployee where Username = @username";
            using (con = new SqlConnection(DataBase.DbConnectionString))
            {
                con.Open();
                Employee emp = new Employee();
                
                try
                {
                    emp = con.Query<Employee>(sqlGetEmployeeByUsername, new { username }).FirstOrDefault();
                    s = emp.Salt;
                }
                catch (Exception)
                {
                    s = "";                    
                }
                con.Close();
                con.Dispose();
                
            }
            return s;
        }
    }
}

