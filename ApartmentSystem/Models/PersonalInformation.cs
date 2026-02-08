using System;
using System.ComponentModel.DataAnnotations;

namespace ApartmentSystem.Models
{
    public class PersonalInformation
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(100)]
        [Display(Name = "Email Address")]
        public string ? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        [StringLength(20)]
        [Display(Name = "Phone Number")]
        public string ?PhoneNumber { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Display(Name = "Gender")]
       
        public string ?Gender { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 200 characters")]
        [Display(Name = "Street Address")]
        public string ? Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "City must be between 2 and 50 characters")]
        [Display(Name = "City")]
        public string ?City { get; set; }

        [Required(ErrorMessage = "Province/State is required")]
        [StringLength(50)]
        [Display(Name = "Province/State")]
        public string ?Province { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [StringLength(20)]
        [Display(Name = "Postal Code")]
        public string ?PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(50)]
        [Display(Name = "Country")]
        public string ?Country { get; set; }

        [StringLength(500)]
        [Display(Name = "Bio")]
        [DataType(DataType.MultilineText)]
        public string ?Bio { get; set; }

       
    }

    
}