using MessagePack;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMS.Models
{
    public class Contacts
    {
        //PROPERTIES
        public Guid Contact_Id { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [MinLength(2, ErrorMessage = "The first name is too short")]
        public string? FirstName { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "The last name is too short")]
        
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email Address")]
        public string? Email { get; set; }


        [Required]
        [RegularExpression(@"^(09|\+639)\d{9}$", ErrorMessage = "Incorrect format. Use +639XXXXXXXXX or 09XXXXXXXXX")]
        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }


        [Required]
        [DisplayName("Gender")]
        public GenderType? Gender { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Date of Birth")]
        public DateTime? DOB { get; set; }



        [DisplayName("Contact Owner")]
        public Guid? ContactOwnerID { get; set; } //Foreign Key: UserID from Application User


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateAssigned { get; set; }


        
        [DisplayName("Contact Creator")]
        public Guid? ContactCreatorID { get; set; } //Foreign Key: UserID from Application User


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreateDate { get; set; }

        
        public bool IsLocal { get; set; } = true;

        
        public Guid? UpdatedBy { get; set; } //Foreign Key: UserID from Application User

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? UpdateDate { get; set; }

        //Computed property
        [IgnoreMember]
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        //FOREIGN ENTITY
        public ApplicationUser? Creator { get; set; }
        public ApplicationUser? Owner { get; set; }
        public ApplicationUser? Updater { get; set; }
        public RollingTransactions? Transactions { get; set; }


        //CONSTRUCTORS
        public Contacts() { }

        public Contacts(
            Guid contact_Id, string? firstName, string? lastName, string? email, string? phoneNumber,
            GenderType? gender, DateTime? dOB, Guid? contactOwnerID, DateTime? dateAssigned,
            Guid? contactCreatorID, DateTime? createDate, Guid? updatedBy, DateTime? updateDate, bool isLocal = false)
        {
            Contact_Id = contact_Id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender;
            DOB = dOB;
            ContactOwnerID = contactOwnerID;
            DateAssigned = dateAssigned;
            ContactCreatorID = contactCreatorID;
            CreateDate = createDate;
            UpdatedBy = updatedBy;
            UpdateDate = updateDate;
            IsLocal = isLocal;
        }
    }

    //GENDER SELECTION
    public enum GenderType
    {
        Male,
        Female,
        Other
    }

}
