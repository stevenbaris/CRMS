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

        public async Task<Product> CreateAsync(Product product)
        {
            try
            {
                _dbContext.Products.Add(product);
                await _dbContext.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while creating the product", ex);
            }
        }

        public async Task<Product> DeleteAsync(Guid id)
        {
            try
            {
                var product = await _dbContext.Products.FindAsync(id);
                if (product == null) { 
                    return null;
                }
                _dbContext.Products.Remove(product);
                await _dbContext.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while deleting the product", ex);
            }
        }

        public async Task<List<Product>> GetAllAsync()
        {
            try
            {
                return await _dbContext.Products.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while getting all products", ex);
            }
        }

        public async Task<Product> GetbyIdAsync(Guid id)
        {
            try
            {
                return await _dbContext.Products.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while getting the product by ID", ex);
            }
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            try
            {
                _dbContext.Entry(product).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while updating the product", ex);
            }
        }
    }
}
