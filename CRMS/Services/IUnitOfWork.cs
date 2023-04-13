namespace CRMS.Services
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }

        IRoleRepository Role { get; }

    }
}
