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
            //arrenge
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
            //arrenge
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
            //arrenge
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
    }
}
