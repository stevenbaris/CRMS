using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMS.Models
{
    public class User
    {
        [DisplayName("User ID")]
        public Guid UserId { get; set; }
        [DisplayName("First Name")]
        [MinLength(2, ErrorMessage =
            "The first name is too short")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [MinLength(2, ErrorMessage =
            "The first name is too short")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required]
        public DateTime DOB { get; set; }
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Must be a valid email")]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [DisplayName("Phone Number")]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "This is not a valid phone number")]
        [Required]
        public string Phone { get; set; }
        [MinLength(5, ErrorMessage =
            "The Address is too short")]
        [Required]
        public string Address { get; set; }
        [DisplayName("Role")]
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }

        public User() { }

        public User(Guid userId, string firstName, string lastName, DateTime dOB, string email, 
            string password, string phone, string address, Guid roleId, Role? role)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            DOB = dOB;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
            RoleId = roleId;
            Role = role;
        }
    }
}
