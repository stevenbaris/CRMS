using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRMS.Models;
using System.Xml.Linq;

namespace CRMS.ViewModels.User
{
    public class EditUserViewModel
    {
        public ApplicationUser User { get; set; }
        public string? Role { get; set; }

        [Display(Name = "Role")]
        public SelectList RoleName { get; set; }
    }
}
