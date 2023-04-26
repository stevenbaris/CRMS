using CustomersAPI.Data;
using CustomersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomersAPI.Repository.MSSQL
{
    public class CustomerDBRepo : ICustomerDBRepository
    {
        private readonly CustomerDBContext _custDBcontext;

        public CustomerDBRepo(CustomerDBContext custDBcontext)
        {
            _custDBcontext = custDBcontext;
        }

        public async Task<Customer> CreateAsync(Customer cust)
        {
            try
            {
                _custDBcontext.Customers.Add(cust);
                await _custDBcontext.SaveChangesAsync();
                return cust;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in creating customer", ex);
            }
        }

        public async Task<Customer> DeleteAsync(Guid id)
        {
            try
            {
                var cust = await _custDBcontext.Customers.FindAsync(id);
                if (cust == null)
                {
                    return null;
                }
                _custDBcontext.Customers.Remove(cust);
                await _custDBcontext.SaveChangesAsync();
                return cust;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in deleting customer", ex);
            }
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            try
            {
                return await _custDBcontext.Customers.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in getting all customers", ex);
            }
        }

        public async Task<Customer> GetbyIdAsync(Guid id)
        {
            try
            {
                return await _custDBcontext.Customers.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in getting customer by id", ex);
            }
        }

        public async Task<Customer> UpdateAsync(Customer cust)
        {
            try
            {
                _custDBcontext.Entry(cust).State = EntityState.Modified;
                await _custDBcontext.SaveChangesAsync();
                return cust;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in updating customer", ex);
            }
        }

    }
}
