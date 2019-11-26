using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Service
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        List<Employee> GetEmployees();
        [OperationContract]
        List<Customer> GetCustomers();
        [OperationContract]
        Employee GetEmployeeById(int SearchId);
        [OperationContract]
        bool LogOn(string user, string pass);
        [OperationContract]
        List<Movie> GetAllMovies();
        [OperationContract]
        Movie GetMovie(int id);
        [OperationContract]
        List<Hall> FindHalls(int id);
        [OperationContract]
        List<Reservation> FindAllReservations();
        [OperationContract]
        Reservation FindReservationById(int Id);
        [OperationContract]
        void InsertReservation(Reservation r);
    }
}
