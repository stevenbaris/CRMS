using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRMS.Models
{
    public class Product
    {
        public Guid Product_Id { get; set; }


        [Required]
        [StringLength(50)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }


        [Required]
        [DisplayName("Product Description")]
        [StringLength(500)]
        public string ProductDescription { get; set; }


        [Required]
        [DisplayName("Product Benefits")]
        [StringLength(1000)]
        public string? Benefits { get; set; }



        public Product() { }
        
        public Product(Guid id, string productName, string productDescription, string benefits)
        {
            Product_Id = id;
            ProductName = productName;
            ProductDescription = productDescription;
            Benefits = benefits;
        }
    }
}
