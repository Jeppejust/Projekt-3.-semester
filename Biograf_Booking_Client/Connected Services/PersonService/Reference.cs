﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biograf_Booking_Client.PersonService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Biograf_Booking_Server.Model")]
    [System.SerializableAttribute()]
    public partial class Employee : Biograf_Booking_Client.PersonService.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeIdField, value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/Biograf_Booking_Server.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Biograf_Booking_Client.PersonService.Customer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Biograf_Booking_Client.PersonService.Employee))]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SaltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FName {
            get {
                return this.FNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FNameField, value) != true)) {
                    this.FNameField = value;
                    this.RaisePropertyChanged("FName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LName {
            get {
                return this.LNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LNameField, value) != true)) {
                    this.LNameField = value;
                    this.RaisePropertyChanged("LName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNoField, value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salt {
            get {
                return this.SaltField;
            }
            set {
                if ((object.ReferenceEquals(this.SaltField, value) != true)) {
                    this.SaltField = value;
                    this.RaisePropertyChanged("Salt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Biograf_Booking_Server.Model")]
    [System.SerializableAttribute()]
    public partial class Customer : Biograf_Booking_Client.PersonService.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerIdField, value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/Biograf_Booking_Server.Model")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MovieIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MovieLengthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PremiereDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResumeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImagePath {
            get {
                return this.ImagePathField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagePathField, value) != true)) {
                    this.ImagePathField = value;
                    this.RaisePropertyChanged("ImagePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MovieId {
            get {
                return this.MovieIdField;
            }
            set {
                if ((this.MovieIdField.Equals(value) != true)) {
                    this.MovieIdField = value;
                    this.RaisePropertyChanged("MovieId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MovieLength {
            get {
                return this.MovieLengthField;
            }
            set {
                if ((this.MovieLengthField.Equals(value) != true)) {
                    this.MovieLengthField = value;
                    this.RaisePropertyChanged("MovieLength");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PremiereDate {
            get {
                return this.PremiereDateField;
            }
            set {
                if ((this.PremiereDateField.Equals(value) != true)) {
                    this.PremiereDateField = value;
                    this.RaisePropertyChanged("PremiereDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Resume {
            get {
                return this.ResumeField;
            }
            set {
                if ((object.ReferenceEquals(this.ResumeField, value) != true)) {
                    this.ResumeField = value;
                    this.RaisePropertyChanged("Resume");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetEmployees", ReplyAction="http://tempuri.org/IPersonService/GetEmployeesResponse")]
        System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Employee> GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetEmployees", ReplyAction="http://tempuri.org/IPersonService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Employee>> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetCustomers", ReplyAction="http://tempuri.org/IPersonService/GetCustomersResponse")]
        System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Customer> GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetCustomers", ReplyAction="http://tempuri.org/IPersonService/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Customer>> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetEmployeeById", ReplyAction="http://tempuri.org/IPersonService/GetEmployeeByIdResponse")]
        Biograf_Booking_Client.PersonService.Employee GetEmployeeById(int SearchId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetEmployeeById", ReplyAction="http://tempuri.org/IPersonService/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<Biograf_Booking_Client.PersonService.Employee> GetEmployeeByIdAsync(int SearchId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/LogOn", ReplyAction="http://tempuri.org/IPersonService/LogOnResponse")]
        bool LogOn(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/LogOn", ReplyAction="http://tempuri.org/IPersonService/LogOnResponse")]
        System.Threading.Tasks.Task<bool> LogOnAsync(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAllMovies", ReplyAction="http://tempuri.org/IPersonService/GetAllMoviesResponse")]
        System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Movie> GetAllMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAllMovies", ReplyAction="http://tempuri.org/IPersonService/GetAllMoviesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Movie>> GetAllMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetMovie", ReplyAction="http://tempuri.org/IPersonService/GetMovieResponse")]
        Biograf_Booking_Client.PersonService.Movie GetMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetMovie", ReplyAction="http://tempuri.org/IPersonService/GetMovieResponse")]
        System.Threading.Tasks.Task<Biograf_Booking_Client.PersonService.Movie> GetMovieAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : Biograf_Booking_Client.PersonService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<Biograf_Booking_Client.PersonService.IPersonService>, Biograf_Booking_Client.PersonService.IPersonService {
        
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
        
        public System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Employee> GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Employee>> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Customer> GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Customer>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public Biograf_Booking_Client.PersonService.Employee GetEmployeeById(int SearchId) {
            return base.Channel.GetEmployeeById(SearchId);
        }
        
        public System.Threading.Tasks.Task<Biograf_Booking_Client.PersonService.Employee> GetEmployeeByIdAsync(int SearchId) {
            return base.Channel.GetEmployeeByIdAsync(SearchId);
        }
        
        public bool LogOn(string user, string pass) {
            return base.Channel.LogOn(user, pass);
        }
        
        public System.Threading.Tasks.Task<bool> LogOnAsync(string user, string pass) {
            return base.Channel.LogOnAsync(user, pass);
        }
        
        public System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Movie> GetAllMovies() {
            return base.Channel.GetAllMovies();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Biograf_Booking_Client.PersonService.Movie>> GetAllMoviesAsync() {
            return base.Channel.GetAllMoviesAsync();
        }
        
        public Biograf_Booking_Client.PersonService.Movie GetMovie(int id) {
            return base.Channel.GetMovie(id);
        }
        
        public System.Threading.Tasks.Task<Biograf_Booking_Client.PersonService.Movie> GetMovieAsync(int id) {
            return base.Channel.GetMovieAsync(id);
        }
    }
}
