namespace CRMS.Services
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetbyIdAsync(Guid id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);
    }
}
