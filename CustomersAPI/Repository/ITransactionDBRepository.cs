using CustomersAPI.Models;

namespace CustomersAPI.Repository
{
    public interface ITransactionDBRepository
    {
        Task<List<Transactions>> GetAllTransactionsAsync();
        //Task<Transactions> GetTransactionsByIdAsync(Guid id);
    }
}
