using FutureEducationalPlatform.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Interfaces.IRepository
{
    public interface IUserRepository:IBaseRepository<User>
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<IEnumerable<string>> GetUserRoles(User user);
    }
}
