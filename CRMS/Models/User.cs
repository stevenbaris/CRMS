using System.Runtime.Intrinsics.Arm;

namespace CRMS.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Guid RolesId { get; set; }
        public Roles? Roles { get; set; }

        public User() { }

        public User(Guid userId, string firstName, string lastName, DateTime dOB, string email, 
            string password, string phone, string address, Guid rolesId, Roles? roles)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            DOB = dOB;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
            RolesId = rolesId;
            Roles = roles;
        }
    }
}
