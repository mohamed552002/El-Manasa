using FutureEducationalPlatform.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Interfaces.IServices
{
    public interface IRoleService
    {
        Task<IEnumerable<string>> GetUserRoles(User user);
        Task AddToRoleAsync(User user, string roleName);
    }
}
