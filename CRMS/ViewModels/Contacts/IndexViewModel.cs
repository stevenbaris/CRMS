using CRMS.Models;

public class IndexViewModel
{
    public bool IsAdmin { get; set; }
    public List<Contacts>? AllContacts { get; set; }
    public List<Contacts>? MyContacts { get; set; }
    public List<Contacts>? UnassignedContacts { get; set; }
    public List<Contacts>? AssignedContacts { get; set; }
}
