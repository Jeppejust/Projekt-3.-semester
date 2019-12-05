using Biograf_Booking_Server.Controller;
using Biograf_Booking_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biograf_Booking_Server.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class PersonService : IPersonService
    {
        private EmployeeCtrl EmpCtrl = new EmployeeCtrl();
        private CustomerCtrl CustCtrl = new CustomerCtrl();
        private MovieCtrl MovCtrl = new MovieCtrl();
        private HallCtrl HCtrl = new HallCtrl();
        private ReservationCtrl ResCtrl = new ReservationCtrl();
        private SeatCtrl SeCtrl = new SeatCtrl();


        //[OperationBehavior(TransactionScopeRequired = true)]
        public List<Customer> GetCustomers()
        {
            return CustCtrl.GetCustomers();
        }

        public List<Employee> GetEmployees()
        {
            return EmpCtrl.GetEmployees();
        }

        public Employee GetEmployeeById(int SearchId)
        {
            return EmpCtrl.GetEmployeeById(SearchId);
        }

        public bool LogOn(string user, string pass)
        {
            return EmpCtrl.ComparePassword(user,pass);
        }
        public List<Movie> GetAllMovies()
        {
            return MovCtrl.GetAllMovies();
        }
        public Movie GetMovie(int id)
        {
            return MovCtrl.GetMovie(id);
        }

        public List<Hall> FindHalls(int id)
        {
            return HCtrl.FindHalls(id); 
        }

        public List<Reservation> FindAllReservations()
        {
            return ResCtrl.FindAllReservations();
        }
        public Reservation FindReservationById(int Id)
        {
            return ResCtrl.FindReservationById(Id);
        }
       public bool InsertReservation(Reservation r)
        {
            return ResCtrl.InsertReservation(r);
        }
        public List<Seat> FindSeatsByHallId(int HallId)
        {
            return SeCtrl.FindSeatsByHallId(HallId);
        }
        public Customer InsertCustomer(Customer c)
        {
            return CustCtrl.InsertCustomer(c);
        }
        public Customer LoginCustomer(string email, string pass)
        {
            return CustCtrl.ComparePassword(email, pass);
        }
    }
}
