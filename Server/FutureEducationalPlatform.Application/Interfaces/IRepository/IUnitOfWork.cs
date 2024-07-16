using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Application.Interfaces.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<T> GetRepository<T>() where T : BaseModel;
        Task CompleteAsync();
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }

    } 
}

