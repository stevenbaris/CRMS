namespace CRMS.Models
{
    public class Contacts
    {
        //PROPERTIES
        public Guid Contact_Id { get; set; }
        public string FirstName { get; set; } = "--";
        public string LastName { get; set; } = "--";
        public string Email { get; set; } = "--";
        public string PhoneNumber { get; set; } = "--";
        public GenderType? Gender { get; set; }
        public DateTime? DOB { get; set; }
        public Guid? ContactOwnerID { get; set; } //Foreign Key: UserID from Application User
        public DateTime? DateAssigned { get; set; }
        public Guid? ContactCreatorID { get; set; } //Foreign Key: UserID from Application User
        public DateTime? CreateDate { get; set; }


        //FOREIGN ENTITY
        public ApplicationUser? User { get; set; }
        public RollingTransactions? Transactions { get; set; }


        //CONSTRUCTORS
        public Contacts() { }

        public Contacts(string firstName, string lastName, string email, string phoneNumber, GenderType? gender, DateTime? dOB, Guid? contactOwnerID, DateTime? dateAssigned, Guid? contactCreatorID, DateTime? createDate)
        {
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
        }
    }

    //GENDER SELECTION
    public enum GenderType
    {
        Male,
        Female,
        NonBinary
    }

}
