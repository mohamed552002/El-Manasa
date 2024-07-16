using FutureEducationalPlatform.Domain.Entities.UserEntities;

namespace FutureEducationalPlatform.Application.Interfaces.IRepository
{
    public interface IRoleRepository:IBaseRepository<UserRoles>
    {
        Task<IEnumerable<string>> GetUserRoles(User user);
        Task AddToRoleAsync(User user, string roleName);
    }
}
