using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.Model;

namespace ProductAPI.Repository
{
    public class ProductDBRepository : IProductRepository
    {
        ProductDbContext _dbContext;

        public ProductDBRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product AddProduct(Product newProduct)
        {
            _dbContext.Add(newProduct);
            _dbContext.SaveChanges();
            return newProduct;
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.AsNoTracking().ToList();
        }
    }
}
