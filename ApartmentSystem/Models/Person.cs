namespace ApartmentSystem.Models
{
    public class Person
    {

        public int Id { get; set; } 
        public required string FirstName { get; set; }   
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int  age 
        { 
            get 
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
}

    }
}
