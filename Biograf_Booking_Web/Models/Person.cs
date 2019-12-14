using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Biograf_Booking_Web.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Fornavn er påkrævet.")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Efternavn er påkrævet.")]
        public string LName { get; set; }
        [Required(ErrorMessage = "Mobil nr. er påkrævet.")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Email er påkrævet.")]
        [EmailAddress]
        public string Email { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage = "Adgangskode er påkrævet.")]
        public string Password { get; set; }
        public string Salt { get; set; }


    }
}
