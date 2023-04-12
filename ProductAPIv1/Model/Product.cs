using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Model
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string? Benefits { get; set; }

        public Product() { }
        
        public Product(Guid id, string productName, string productDescription, string benefits)
        {
            Id = id;
            ProductName = productName;
            ProductDescription = productDescription;
            Benefits = benefits;
        }
    }
}
