using System.ComponentModel.DataAnnotations;

namespace ApartmentSystem.Models
{
    public enum ContactSubject
    {
        None = 0,
        [Display(Name = "General inquiry")]
        General = 1,
        [Display(Name = "Support")]
        Support = 2,
        [Display(Name = "Sales")]
        Sales = 3,
        [Display(Name = "Feedback")]
        Feedback = 4
    }

    public class ContactInfo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your full name.")]
        [Display(Name = "Full Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select a subject.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a subject.")]
        [Display(Name = "Subject")]
        public ContactSubject Subject { get; set; }

        [Required(ErrorMessage = "Please enter a message.")]
        [Display(Name = "Message")]
        [DataType(DataType.MultilineText)]
        [StringLength(2000, MinimumLength = 5)]
        public string Message { get; set; }
    }
}