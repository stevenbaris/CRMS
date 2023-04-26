using CustomersAPI.Models;

namespace CustomersAPI.Repository
{
    public interface ICustomerDBRepository
    {
        Task<List<Customer>> GetAllCustomersAsync();

        Task<Customer> GetbyIdAsync(Guid id);
        Task<Customer> CreateAsync(Customer cust);
        Task<Customer> UpdateAsync(Customer cust);
        Task<Customer> DeleteAsync(Guid id);
        //Task<Customer> GetCustomerByIdAsync(Guid id);
    }
}
