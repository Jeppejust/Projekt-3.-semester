using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biograf_Booking_Server.Service;
using Biograf_Booking_Server.Model;
using Biograf_Booking_Server.Database;

namespace Biograf_Booking_Server.Controller
{
    public class EmployeeCtrl
    {
        private IEmployeeRepository<Employee> IEmpRepo = null;
        public EmployeeCtrl()
        {
            IEmpRepo = new EmployeeRepository();
        }
        public List<Employee> GetEmployees()
        {
            return IEmpRepo.GetEmployees();
        }

        public Employee GetEmployeeById(int SearchId)
        {
            return IEmpRepo.GetEmployeeById(SearchId);
        }

        public Employee LogOn(string user, string pass)
        {
            return IEmpRepo.LogOn(user, pass);
        }
        public bool ComparePassword(string username, string pass)
        {
            string salt = IEmpRepo.GetSaltFromEmployeeByUsername(username);
            string HashedPass = GenerateSHA256Hash(pass, salt);
            Employee em = new Employee();
            bool LogOnBool;
            try
            {
                em = LogOn(username, HashedPass);
                LogOnBool = true;
            }
            catch (Exception)
            {
                LogOnBool = false;
            }
            if (em == null)
            {
                LogOnBool = false;
            }
            return LogOnBool;
        }

        public static String GenerateSHA256Hash(String input, string salt) 
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            return ByteArrayToHexString(hash);
        }
        private static String ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
    }
}
