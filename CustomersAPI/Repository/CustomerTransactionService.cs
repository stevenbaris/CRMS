using CustomersAPI.DTO;
using CustomersAPI.Models;

namespace CustomersAPI.Repository
{
    public class CustomerTransactionService
    {
        private readonly ICustomerDBRepository _customerRepository;
        private readonly ITransactionDBRepository _transactionRepository;

        public CustomerTransactionService(ICustomerDBRepository customerRepository, 
                                          ITransactionDBRepository transactionRepository)
        {
            _customerRepository = customerRepository;
            _transactionRepository = transactionRepository;
        }


        public async Task<List<CustomerTransactionDTO>> GetCustomersAndTransactionAsync()
        {
            var customers = await _customerRepository.GetAllCustomersAsync();
            var orders = await _transactionRepository.GetAllTransactionsAsync();

            var customersAndOrders = customers.Select(c => new CustomerTransactionDTO
            {
                CustomerId = c.Customer_Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Gender = c.Gender,
                Email = c.Email,
                Phone = c.Phone,
                DOB = c.DOB,

                Transactions = orders.Where(o => o.CustomerId == c.Customer_Id).Select(o => new TransactionDTO
                {
                    TransactionID = o.Transaction_Id,
                    Amount = o.Amount
                }).ToList()
            }).ToList();

            return customersAndOrders;
        }
    }
}
