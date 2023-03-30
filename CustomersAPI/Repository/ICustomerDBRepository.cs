using CustomersAPI.Models;

namespace CustomersAPI.Repository
{
    public interface ICustomerDBRepository
    {
        Task<List<Customer>> GetAllCustomersAsync(); 
        //Task<Customer> GetCustomerByIdAsync(Guid id);
    }
}
