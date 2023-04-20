using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProductAPI.DTO
{
    public class ProductDTO
    {

        [Required]
        [StringLength(50)]
        [DisplayName("Product Name")]
        public string? ProductName { get; set; }


        [Required]
        [DisplayName("Product Description")]
        [StringLength(500)]
        public string? ProductDescription { get; set; }


        [Required]
        [DisplayName("Product Benefits")]
        [StringLength(1000)]
        public string? Benefits { get; set; }

    }
}
