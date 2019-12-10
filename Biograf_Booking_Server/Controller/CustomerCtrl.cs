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
        public Customer LogOn(string email, string pass)
        {
            return ICustRepo.LogOn(email, pass);
        }
        public Customer ComparePassword(string email, string pass)
        {
            string salt = ICustRepo.GetSaltFromCustomerByEmail(email);
            string HashedPass = GenerateSHA256Hash(pass, salt);
            Customer cus = new Customer();
            try
            {
                cus = LogOn(email, HashedPass);
                
            }
            catch (Exception)
            {
                cus = null;
            }
            return cus;
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
        private string CreateSalt()
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[10];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        
        public Customer InsertCustomer(Customer c)
        {
            Customer tempC = new Customer();
            c.Salt = CreateSalt();
            c.Password = GenerateSHA256Hash(c.Password, c.Salt);
            bool ins = ICustRepo.InsertCustomer(c);
            if (ins==true)
            {
                tempC = ICustRepo.GetCustomerByEmail(c.Email);
            }
            return tempC;
        }
    }
}
