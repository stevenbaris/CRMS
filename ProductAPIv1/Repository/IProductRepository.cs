using ProductAPI.Model;

namespace ProductAPI.Repository
{
    public interface IProductRepository
    {
            List<Product> GetAllProducts();

            Product AddProduct(Product newProduct);
        
    }
}
