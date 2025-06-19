using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeamLID.TravelExperts.Repository.Domain
{
    public partial class Customers
    {
        public Customers()
        {
            Bookings = new HashSet<Bookings>();
            CreditCards = new HashSet<CreditCards>();
            CustomersRewards = new HashSet<CustomersRewards>();
        }

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [DisplayName("First Name")]
        public string CustFirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [DisplayName("Last Name")]
        public string CustLastName { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [DisplayName("Address")]
        public string CustAddress { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [DisplayName("City")]
        public string CustCity { get; set; }

        [Required(ErrorMessage = "Province is required.")]
        [DisplayName("Province")]
        public string CustProv { get; set; }

        [Required(ErrorMessage = "Postal code is required.")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Postal code must be 5 digits.")]
        [DisplayName("Zip Code")]
        public string CustPostal { get; set; }

        [DisplayName("Country")]
        public string CustCountry { get; set; }

        [RegularExpression(@"^(010|011|012|015)[0-9]{8}$", ErrorMessage = "Invalid Egyptian phone number.")]
        [DisplayName("Home Phone")]
        public string CustHomePhone { get; set; }

        [Required(ErrorMessage = "Business phone is required.")]
        [RegularExpression(@"^(010|011|012|015)[0-9]{8}$", ErrorMessage = "Invalid Egyptian phone number.")]
        [DisplayName("Business Phone")]
        public string CustBusPhone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [DisplayName("Email")]
        public string CustEmail { get; set; }

        public int? AgentId { get; set; }
        public bool WantsAdmin { get; set; } = false;
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;

        public virtual Agents Agent { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }
        public virtual ICollection<CreditCards> CreditCards { get; set; }
        public virtual ICollection<CustomersRewards> CustomersRewards { get; set; }
    }
}
