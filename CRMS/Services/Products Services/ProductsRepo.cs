using CRMS.Data;
using CRMS.Exceptions;
using CRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.Products_Services
{
    public class ProductsRepo:IRepository<Product>
    {
        private readonly CRMSDbContext _dBcontext;

        public ProductsRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            try
            {
                _dBcontext.Products.Add(product);
                await _dBcontext.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while creating product.", ex);
            }
        }

        public async Task<Product> DeleteAsync(Guid id)
        {
            try
            {
                var product = await GetbyIdAsync(id);
                if (product != null)
                {
                    _dBcontext.Products.Remove(product);
                    await _dBcontext.SaveChangesAsync();
                }
                else
                {
                    throw new EntityNotFoundException("Contact not found.");
                }
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while deleting the product.", ex);
            }
        }

        public async Task<List<Product>> GetAllAsync()
        {
            try
            {
                
                return await _dBcontext.Products
                     .AsNoTracking()
                     .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while retrieving all Products.", ex);
            }
        }

        public async Task<Product> GetbyIdAsync(Guid id)
        {
            try
            {
                var product = await _dBcontext.Products
                    .AsNoTracking()
                    .SingleOrDefaultAsync(prod => prod.Product_Id == id);
                if (product == null)
                {
                    throw new EntityNotFoundException("Product not found.");
                }
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while retrieving Product by id.", ex);
            }
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            try
            {
                _dBcontext.Products.Update(product);
                await _dBcontext.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while updating the product.", ex);
            }
        }
    }
}
