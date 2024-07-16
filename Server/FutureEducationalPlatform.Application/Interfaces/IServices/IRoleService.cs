using FutureEducationalPlatform.Domain.Entities.UserEntities;

namespace FutureEducationalPlatform.Application.Interfaces.IServices
{
    public interface IRoleService
    {
        Task<IEnumerable<string>> GetUserRoles(User user);
        Task AddToRoleAsync(User user, string roleName);
    }
}
