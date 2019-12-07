using Biograf_Booking_Server.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using ps = Biograf_Booking_Server.Controller;

namespace Test_Biograf_Booking
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginSuccesful()
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
        public void TestLoginMissingPass()
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
        public void TestLoginMissingUser()
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
        public void TestLoginMissingUserAndPass()
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
            res.MovieId = 1;
            res.CustomerId = 1;
            Seat s = new Seat();
            s.SeatId = 1;
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

    }
}
