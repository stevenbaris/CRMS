using CustomersAPI.Data;
using CustomersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomersAPI.Repository.MSSQL
{
    public class CustomerDBRepo : ICustomerDBRepository
    {
        private readonly CustomerDBContext _dBcontext;

        public CustomerDBRepo(CustomerDBContext custDBcontext)
        {
            _dBcontext = custDBcontext;
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _dBcontext.Customers.AsNoTracking().ToListAsync();
        }

        //public async Task<Customer> GetCustomerByIdAsync(Guid id)
        //{
        //    return await _dBcontext.Customers.AsNoTracking().FirstOrDefaultAsync(cust => cust.Customer_Id==id);
        //        ;
        //}
    }
}
