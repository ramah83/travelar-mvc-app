using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TeamLID.TravelExperts.Repository.Domain;

namespace TeamLID.TravelExperts.App.Models
{
    public class UserViewModel
    {
        public int CustomerId { get; set; }

        [Required, DisplayName("First Name")]
        public string CustFirstName { get; set; }

        [Required, DisplayName("Last Name")]
        public string CustLastName { get; set; }

        [Required, DisplayName("Address")]
        public string CustAddress { get; set; }

        [Required, DisplayName("City")]
        public string CustCity { get; set; }

        [Required, DisplayName("Governorate")]
        public string CustProv { get; set; }

        [Required, DisplayName("Postal Code")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Postal code must be 5 digits.")]
        public string CustPostal { get; set; }

        [DisplayName("Country")]
        public string CustCountry { get; set; }

        [DisplayName("Home Phone")]
        [RegularExpression(@"^(010|011|012|015)[0-9]{8}$", ErrorMessage = "Home phone must be a valid Egyptian mobile number.")]
        public string CustHomePhone { get; set; }

        [Required, DisplayName("Business Phone")]
        [RegularExpression(@"^(010|011|012|015)[0-9]{8}$", ErrorMessage = "Business phone must be a valid Egyptian mobile number.")]
        public string CustBusPhone { get; set; }

        [Required, DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string CustEmail { get; set; }

        [Required, MinLength(5, ErrorMessage = "Username must be at least 5 characters."), MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password), MinLength(5, ErrorMessage = "Password must be at least 5 characters."), MaxLength(50)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password)), DisplayName("Confirm Password")]
        public string PasswordConfirm { get; set; }

        public int? AgentId { get; set; }
    }
}
