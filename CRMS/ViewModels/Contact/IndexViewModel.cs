using CRMS.Models;

public class IndexViewModel
{
    public bool IsAdmin { get; set; }
    public Contacts? Contacts { get; set; } = new Contacts();
    public List<Contacts>? AllContacts { get; set; } = new List<Contacts>();
    public List<Contacts>? MyContacts { get; set; } = new List<Contacts>();
    public List<Contacts>? UnassignedContacts { get; set; } = new List<Contacts>();
    public List<Contacts>? AssignedContacts { get; set; } = new List<Contacts>();
    public List<ApplicationUser> AppUsers { get; set; } = new List<ApplicationUser>();

}
