namespace CRMS.ViewModels
{
    public class ContactsViewModel
    {
        public string FirstName { get; set; } = "--";
        public string LastName { get; set; } = "--";
        public string Email { get; set; } = "--";
        public string PhoneNumber { get; set; } = "--";
        public string Gender { get; set; } = "--";
        public DateTime? DOB { get; set; }
        public Guid ContactOwnerID { get; set; } = Guid.Empty;
        public DateTime? DateAssigned { get; set; }
        public Guid ContactCreatorID { get; set; } = Guid.Empty;
        public DateTime? CreateDate { get; set; }
        public Decimal RollingTransactions { get; set; }


        public ContactsViewModel() { }
    }
}
