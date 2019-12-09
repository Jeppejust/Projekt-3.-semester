using Biograf_Booking_Server.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using ps = Biograf_Booking_Server.Controller;

namespace Test_Biograf_Booking
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginEmployeeSuccesful()
        {
            //arrenge
            string username = "admin";
            string pass = "admin";
            bool verified = false;
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //act
                verified = proxy.LogOn(username, pass);
                
            }
            //assert
            Assert.IsTrue(verified);
        }
        [TestMethod]
        public void TestLoginEmployeeMissingPass()
        {
            //Arrange
            string username = "admin";
            string pass = "";
            bool verified = false;
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //act
                verified = proxy.LogOn(username, pass);

            }
            //assert
            Assert.IsFalse(verified);
        }
        [TestMethod]
        public void TestLoginEmployeeMissingUser()
        {
            //Arrange
            string username = "";
            string pass = "admin";
            bool verified = false;
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //act
                verified = proxy.LogOn(username, pass);

            }
            //assert
            Assert.IsFalse(verified);
        }
        [TestMethod]
        public void TestLoginEmployeeMissingUserAndPass()
        {
            //Arrange
            string username = "";
            string pass = "";
            bool verified = false;
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //act
                verified = proxy.LogOn(username, pass);

            }
            //assert
            Assert.IsFalse(verified);
        }
        [TestMethod]
        public void TestInsertResSuccess()
        {
            //Arrange
            Reservation res = new Reservation();
            res.Seats = new List<Seat>();
            res.MovieId = 1;
            res.CustomerId = 1;
            Seat s = new Seat();
            s.SeatId = 56; //Open the program and choose a free seat before running the test
            res.Seats.Add(s);
            bool verified = false;
            using(PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //Act
                verified = proxy.InsertReservation(res);
            }
            //Assert
            Assert.IsTrue(verified);
        }
        [TestMethod]
        public void TestInsertResWithBookedSeat()
        {
            //Arrange
            Reservation res = new Reservation();
            res.Seats = new List<Seat>();
            res.MovieId = 1;
            res.CustomerId = 1;
            Seat s = new Seat();
            s.SeatId = 1; 
            res.Seats.Add(s);
            bool verified = false;
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //Act
                verified = proxy.InsertReservation(res);
            }
            //Assert
            Debug.WriteLine("verified: " + verified);
            Assert.IsFalse(verified);
        }
        [TestMethod]
        public void TestInsertResWithNoMovie()
        {
            //Arrange
            Reservation res = new Reservation();
            res.Seats = new List<Seat>();
            
            res.CustomerId = 1;
            Seat s = new Seat();
            s.SeatId = 13;//Open the program and choose a free seat before running the test
            res.Seats.Add(s);
            bool verified = false;
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //Act
                verified = proxy.InsertReservation(res);
            }
            //Assert
            Assert.IsFalse(verified);
        }
        [TestMethod]
        public void TestInsertResWithNoCustomer()
        {
            //Arrange
            Reservation res = new Reservation();
            res.Seats = new List<Seat>();
            res.MovieId = 1;
            
            Seat s = new Seat();
            s.SeatId = 12;//Open the program and choose a free seat before running the test
            res.Seats.Add(s);
            bool verified = false;
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //Act
                verified = proxy.InsertReservation(res);
            }
            //Assert
            Assert.IsFalse(verified);
        }
        [TestMethod]
        public void TestInsertResWithNoSeats()
        {
            //Arrange
            Reservation res = new Reservation();
            res.Seats = new List<Seat>();
            res.MovieId = 1;
            res.CustomerId = 1;
            bool verified = false;
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //Act
                verified = proxy.InsertReservation(res);
            }
            //Assert
            Assert.IsFalse(verified);
        }
        public void TestLoginCustomerSuccesful()
        {
            //arrenge
            string email = "sarahwohlin@hotmail.com";
            string pass = "MorogFar123";
            Customer customer = new Customer();
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //act
                customer = proxy.LoginCustomer(email, pass);

            }
            //assert
            Assert.IsNotNull(customer);
        }
        public void TestLoginCustomerMissingEmail()
        {
            //arrenge
            string email = "";
            string pass = "MorogFar123";
            Customer customer = new Customer();
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //act
                customer = proxy.LoginCustomer(email, pass);

            }
            //assert
            Assert.IsNull(customer);
        }
        public void TestLoginCustomerMissingPass()
        {
            //arrenge
            string email = "sarahwohlin@hotmail.com";
            string pass = "";
            Customer customer = new Customer();
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //act
                customer = proxy.LoginCustomer(email, pass);

            }
            //assert
            Assert.IsNull(customer);
        }
        public void TestLoginCustomerMissingEmailAndPass()
        {
            //arrenge
            string username = "";
            string pass = "";
            Customer customer = new Customer(); ;
            using (PersonService.PersonServiceClient proxy = new PersonService.PersonServiceClient())
            {
                //act
                customer = proxy.LoginCustomer(username, pass);

            }
            //assert
            Assert.IsNull(customer);
        }
    }
}
