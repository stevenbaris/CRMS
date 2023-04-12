using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMS.Models.Customization
{
    public class Effectivity
    {
        public Guid Effectivity_Id { get; set; } = Guid.Empty;

        [Required]
        [DisplayName("Effectivity: ")]
        public string Effectivity_Name { get; set; } = string.Empty;

        public Effectivity() { }

        public Effectivity(Guid effectivity_Id, string effectivity_Name)
        {
            Effectivity_Id = effectivity_Id;
            Effectivity_Name = effectivity_Name;
        }
    }
}
