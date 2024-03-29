// <copyright file="ReservationRepositoryTest.cs">Copyright ©  2019</copyright>
using System;
using Biograf_Booking_Server.Database;
using Biograf_Booking_Server.Model;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Biograf_Booking_Server.Database.Tests
{
    /// <summary>This class contains parameterized unit tests for ReservationRepository</summary>
    [PexClass(typeof(ReservationRepository))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ReservationRepositoryTest
    {
        /// <summary>Test stub for InsertReservation(Reservation)</summary>
        [PexMethod]
        internal bool InsertReservationTest([PexAssumeUnderTest]ReservationRepository target, Reservation r)
        {
            bool result = target.InsertReservation(r);
            return result;
            // TODO: add assertions to method ReservationRepositoryTest.InsertReservationTest(ReservationRepository, Reservation)
        }
    }
}
