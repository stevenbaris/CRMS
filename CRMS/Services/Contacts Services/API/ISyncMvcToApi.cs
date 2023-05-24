namespace CRMS.Services.Contacts_Services.API
{
    public interface ISyncMvcToApi<T>
    {
        Task<string> AddApiData(T Entity);
        Task<string> UpdateApiData(Guid Id, T Entity);
        Task<string> DeleteApiData(Guid Id);

    }


}
