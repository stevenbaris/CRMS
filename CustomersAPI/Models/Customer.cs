using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace CustomersAPI.Models
{
    public class Customer
    {

        public Guid Contact_Id { get; set; } = Guid.NewGuid();


        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string FirstName { get; set; } = string.Empty;


        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string LastName { get; set; } = string.Empty;


        [Required]
        [MinLength(4)]
        [MaxLength(6)]
        [RegularExpression(@"^(Male|Female|Non-binary)$", ErrorMessage = "Gender must be 'Male' or 'Female' or 'Non-binary'.")]
        public string Gender { get; set; } = string.Empty;


        [Required]
        public DateTime DOB { get; set; } = new DateTime(1990, 1, 1);


        [Required]
        
        [EmailAddress]
        public string Email { get; set; } = string.Empty;


        [Required]
        [RegularExpression(@"^(09|\+639)\d{9}$", ErrorMessage = "Incorrect format. Use +639XXXXXXXXX or 09XXXXXXXXX")]
        public string PhoneNumber { get; set; } = string.Empty;


        [Required]
        [MinLength(5)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreateDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? UpdateDate { get; set; }


        public ICollection<Transactions>? Transactions { get; set; }




        public Customer()
        {

        }

        public Customer(Guid contact_Id, string firstName, string lastName, string gender, DateTime dOB, string email, string phone, string address, DateTime? createDate, DateTime? updateDate)
        {
            Contact_Id = contact_Id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DOB = dOB;
            Email = email;
            PhoneNumber = phone;
            Address = address;
            CreateDate = createDate;
            UpdateDate = updateDate;
        }
    }
}
