using System.ComponentModel.DataAnnotations;

namespace NETCoreTemplate.Mvc.Models
{
    public class FormViewModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Department { get; set; }
        public string Comments { get; set; }

        [Required(ErrorMessage = "You must agree to the terms and conditions")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms and conditions")]
        public bool AcceptTerms { get; set; }
    }
} 