using CustomersAPI.Data;
using CustomersAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace CustomersAPI.Repository.MSSQL
{
    public class TransactionDBRepo: ITransactionDBRepository
    {
        private readonly CustomerDBContext _dBContext;

        public TransactionDBRepo(CustomerDBContext transDBContext)
        {
            _dBContext = transDBContext;
        }

        public async Task<List<Transactions>> GetAllTransactionsAsync()
        {
            //var options = new JsonSerializerOptions
            //{
            //    PropertyNameCaseInsensitive = true,
            //    ReferenceHandler = ReferenceHandler.Preserve
            //};

            //return await _dBContext.Transactions.Include(db => db.Customer).Select(t => new Transactions
            //{
            //    Transaction_Id = t.Transaction_Id,
            //    Customer = t.Customer != null ? JsonSerializer.Deserialize<Customer>(JsonSerializer.Serialize(t.Customer, typeof(Customer), options)) : null,
            //    // other transaction properties
            //}).ToListAsync();

            return await _dBContext.Transactions.AsNoTracking().ToListAsync();
        }


        //public async Task<Transactions> GetTransactionsByIdAsync(Guid id)
        //{
        //    return await _dBContext.Transactions
        //                    .Include(db => db.Customer)
        //                    .AsNoTracking()
        //                    .FirstOrDefaultAsync(x => x.Transaction_Id == id);
        //}
    }
}
