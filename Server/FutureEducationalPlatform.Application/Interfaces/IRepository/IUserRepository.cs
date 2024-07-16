using FutureEducationalPlatform.Domain.Entities.UserEntities;

namespace FutureEducationalPlatform.Application.Interfaces.IRepository
{
    public interface IUserRepository:IBaseRepository<User>
    {
        Task<User> GetUserByRefreshTokenAsync(string refreshToken);
    }
}
