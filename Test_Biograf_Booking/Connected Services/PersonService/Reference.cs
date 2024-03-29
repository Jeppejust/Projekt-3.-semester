﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_Biograf_Booking.PersonService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetEmployees", ReplyAction="http://tempuri.org/IPersonService/GetEmployeesResponse")]
        System.Collections.Generic.List<Biograf_Booking_Server.Model.Employee> GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetEmployees", ReplyAction="http://tempuri.org/IPersonService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Employee>> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetCustomers", ReplyAction="http://tempuri.org/IPersonService/GetCustomersResponse")]
        System.Collections.Generic.List<Biograf_Booking_Server.Model.Customer> GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetCustomers", ReplyAction="http://tempuri.org/IPersonService/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Customer>> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetEmployeeById", ReplyAction="http://tempuri.org/IPersonService/GetEmployeeByIdResponse")]
        Biograf_Booking_Server.Model.Employee GetEmployeeById(int SearchId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetEmployeeById", ReplyAction="http://tempuri.org/IPersonService/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Employee> GetEmployeeByIdAsync(int SearchId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/LogOn", ReplyAction="http://tempuri.org/IPersonService/LogOnResponse")]
        bool LogOn(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/LogOn", ReplyAction="http://tempuri.org/IPersonService/LogOnResponse")]
        System.Threading.Tasks.Task<bool> LogOnAsync(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAllMovies", ReplyAction="http://tempuri.org/IPersonService/GetAllMoviesResponse")]
        System.Collections.Generic.List<Biograf_Booking_Server.Model.Movie> GetAllMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAllMovies", ReplyAction="http://tempuri.org/IPersonService/GetAllMoviesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Movie>> GetAllMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetMovie", ReplyAction="http://tempuri.org/IPersonService/GetMovieResponse")]
        Biograf_Booking_Server.Model.Movie GetMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetMovie", ReplyAction="http://tempuri.org/IPersonService/GetMovieResponse")]
        System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Movie> GetMovieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/FindHalls", ReplyAction="http://tempuri.org/IPersonService/FindHallsResponse")]
        System.Collections.Generic.List<Biograf_Booking_Server.Model.Hall> FindHalls(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/FindHalls", ReplyAction="http://tempuri.org/IPersonService/FindHallsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Hall>> FindHallsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/FindAllReservations", ReplyAction="http://tempuri.org/IPersonService/FindAllReservationsResponse")]
        System.Collections.Generic.List<Biograf_Booking_Server.Model.Reservation> FindAllReservations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/FindAllReservations", ReplyAction="http://tempuri.org/IPersonService/FindAllReservationsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Reservation>> FindAllReservationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/FindReservationById", ReplyAction="http://tempuri.org/IPersonService/FindReservationByIdResponse")]
        Biograf_Booking_Server.Model.Reservation FindReservationById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/FindReservationById", ReplyAction="http://tempuri.org/IPersonService/FindReservationByIdResponse")]
        System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Reservation> FindReservationByIdAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/InsertReservation", ReplyAction="http://tempuri.org/IPersonService/InsertReservationResponse")]
        bool InsertReservation(Biograf_Booking_Server.Model.Reservation r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/InsertReservation", ReplyAction="http://tempuri.org/IPersonService/InsertReservationResponse")]
        System.Threading.Tasks.Task<bool> InsertReservationAsync(Biograf_Booking_Server.Model.Reservation r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/FindSeatsByHallId", ReplyAction="http://tempuri.org/IPersonService/FindSeatsByHallIdResponse")]
        System.Collections.Generic.List<Biograf_Booking_Server.Model.Seat> FindSeatsByHallId(int HallId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/FindSeatsByHallId", ReplyAction="http://tempuri.org/IPersonService/FindSeatsByHallIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Seat>> FindSeatsByHallIdAsync(int HallId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/LoginCustomer", ReplyAction="http://tempuri.org/IPersonService/LoginCustomerResponse")]
        Biograf_Booking_Server.Model.Customer LoginCustomer(string email, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/LoginCustomer", ReplyAction="http://tempuri.org/IPersonService/LoginCustomerResponse")]
        System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Customer> LoginCustomerAsync(string email, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/InsertCustomer", ReplyAction="http://tempuri.org/IPersonService/InsertCustomerResponse")]
        Biograf_Booking_Server.Model.Customer InsertCustomer(Biograf_Booking_Server.Model.Customer c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/InsertCustomer", ReplyAction="http://tempuri.org/IPersonService/InsertCustomerResponse")]
        System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Customer> InsertCustomerAsync(Biograf_Booking_Server.Model.Customer c);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : Test_Biograf_Booking.PersonService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<Test_Biograf_Booking.PersonService.IPersonService>, Test_Biograf_Booking.PersonService.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Biograf_Booking_Server.Model.Employee> GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Employee>> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public System.Collections.Generic.List<Biograf_Booking_Server.Model.Customer> GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Customer>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public Biograf_Booking_Server.Model.Employee GetEmployeeById(int SearchId) {
            return base.Channel.GetEmployeeById(SearchId);
        }
        
        public System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Employee> GetEmployeeByIdAsync(int SearchId) {
            return base.Channel.GetEmployeeByIdAsync(SearchId);
        }
        
        public bool LogOn(string user, string pass) {
            return base.Channel.LogOn(user, pass);
        }
        
        public System.Threading.Tasks.Task<bool> LogOnAsync(string user, string pass) {
            return base.Channel.LogOnAsync(user, pass);
        }
        
        public System.Collections.Generic.List<Biograf_Booking_Server.Model.Movie> GetAllMovies() {
            return base.Channel.GetAllMovies();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Movie>> GetAllMoviesAsync() {
            return base.Channel.GetAllMoviesAsync();
        }
        
        public Biograf_Booking_Server.Model.Movie GetMovie(int id) {
            return base.Channel.GetMovie(id);
        }
        
        public System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Movie> GetMovieAsync(int id) {
            return base.Channel.GetMovieAsync(id);
        }
        
        public System.Collections.Generic.List<Biograf_Booking_Server.Model.Hall> FindHalls(int id) {
            return base.Channel.FindHalls(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Hall>> FindHallsAsync(int id) {
            return base.Channel.FindHallsAsync(id);
        }
        
        public System.Collections.Generic.List<Biograf_Booking_Server.Model.Reservation> FindAllReservations() {
            return base.Channel.FindAllReservations();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Reservation>> FindAllReservationsAsync() {
            return base.Channel.FindAllReservationsAsync();
        }
        
        public Biograf_Booking_Server.Model.Reservation FindReservationById(int Id) {
            return base.Channel.FindReservationById(Id);
        }
        
        public System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Reservation> FindReservationByIdAsync(int Id) {
            return base.Channel.FindReservationByIdAsync(Id);
        }
        
        public bool InsertReservation(Biograf_Booking_Server.Model.Reservation r) {
            return base.Channel.InsertReservation(r);
        }
        
        public System.Threading.Tasks.Task<bool> InsertReservationAsync(Biograf_Booking_Server.Model.Reservation r) {
            return base.Channel.InsertReservationAsync(r);
        }
        
        public System.Collections.Generic.List<Biograf_Booking_Server.Model.Seat> FindSeatsByHallId(int HallId) {
            return base.Channel.FindSeatsByHallId(HallId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Server.Model.Seat>> FindSeatsByHallIdAsync(int HallId) {
            return base.Channel.FindSeatsByHallIdAsync(HallId);
        }
        
        public Biograf_Booking_Server.Model.Customer LoginCustomer(string email, string pass) {
            return base.Channel.LoginCustomer(email, pass);
        }
        
        public System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Customer> LoginCustomerAsync(string email, string pass) {
            return base.Channel.LoginCustomerAsync(email, pass);
        }
        
        public Biograf_Booking_Server.Model.Customer InsertCustomer(Biograf_Booking_Server.Model.Customer c) {
            return base.Channel.InsertCustomer(c);
        }
        
        public System.Threading.Tasks.Task<Biograf_Booking_Server.Model.Customer> InsertCustomerAsync(Biograf_Booking_Server.Model.Customer c) {
            return base.Channel.InsertCustomerAsync(c);
        }
    }
}
