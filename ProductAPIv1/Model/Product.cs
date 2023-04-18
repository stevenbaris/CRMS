using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Model
{
    public class Product
    {
        public Guid Product_Id { get; set; }

        [Key]
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



        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }


        public Product() { }

        public Product(Guid product_Id, string? productName, string? productDescription, string? benefits, DateTime? createDate, DateTime? updateDate)
        {
            Product_Id = product_Id;
            ProductName = productName;
            ProductDescription = productDescription;
            Benefits = benefits;
            CreateDate = createDate;
            UpdateDate = updateDate;
        }
    }
}
