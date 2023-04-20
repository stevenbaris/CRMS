using System.ComponentModel.DataAnnotations;

namespace CustomersAPI.DTO
{
    public class CustomerDTO
    {

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string FirstName { get; set; }


        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string LastName { get; set; }


        [Required]
        [MinLength(4)]
        [MaxLength(6)]
        [RegularExpression(@"^(Male|Female|Non-binary)$", ErrorMessage = "Gender must be 'Male' or 'Female' or 'Non-binary'.")]
        public string Gender { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOB { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [RegularExpression(@"^(09|\+639)\d{9}$", ErrorMessage = "Incorrect format. Use +639XXXXXXXXX or 09XXXXXXXXX")]
        public string PhoneNumber { get; set; }


        [Required]
        [MinLength(5)]
        public string Address { get; set; }




        public CustomerDTO() { }

        public CustomerDTO(string firstName, string lastName, string gender, DateTime dOB, string email, string phoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DOB = dOB;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
