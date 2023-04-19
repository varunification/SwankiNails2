using System.ComponentModel.DataAnnotations;

namespace SwankiNails2.Models
{
    public class BookingViewModel
    {


        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be 10 digits")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Service is required")]
        [CustomValidation(typeof(BookingViewModel), "ValidateService")]
        public string Service { get; set; }

        public static ValidationResult ValidateService(string service, ValidationContext context)
        {
            if (service.ToLower() == "select")
            {
                return new ValidationResult("Please select a valid service.");
            }

            return ValidationResult.Success;
        }
    }

}
