using CRMS.Data;
using CRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.SqlRepositories
{
    public class RollingTransactionRepo : IRepository<RollingTransactions>
    {
        private readonly CRMSDbContext _dBcontext;

        public RollingTransactionRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        public async Task<RollingTransactions> CreateAsync(RollingTransactions transactions)
        {
            _dBcontext.RollingTransactions.Add(transactions);
            await _dBcontext.SaveChangesAsync();
            return transactions;
        }

        public async Task<RollingTransactions> DeleteAsync(Guid id)
        {
            var transactions = await GetbyIdAsync(id);
            if (transactions != null)
            {
                _dBcontext.RollingTransactions.Remove(transactions);
                await _dBcontext.SaveChangesAsync();
            }
            return transactions;
        }

        public async Task<List<RollingTransactions>> GetAllAsync()
        {
            return await _dBcontext.RollingTransactions.Include(t => t.Contacts).ToListAsync();
        }

        public async Task<RollingTransactions> GetbyIdAsync(Guid id)
        {
            return await _dBcontext.RollingTransactions.Include(t => t.Contacts).SingleOrDefaultAsync(t => t.RollingTransactions_ID == id);
        }

        public async Task<RollingTransactions> UpdateAsync(RollingTransactions transactions)
        {
            _dBcontext.RollingTransactions.Update(transactions);
            await _dBcontext.SaveChangesAsync();
            return transactions;
        }
    }
}
