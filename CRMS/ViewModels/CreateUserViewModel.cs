using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMS.Models;

public class UserFormModel
{
    public Guid UserId { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DOB { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public Guid RolesId { get; set; }
}

public class CreateUserViewModel
{
    public UserFormModel NewUser { get; set; } = new UserFormModel();
    public List<Role> Roles = new();
}