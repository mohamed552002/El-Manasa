using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<User> GetUserByRefreshTokenAsync(string refreshToken)
        {
            var allUsers = await _context.Users.Include(u => u.RefreshTokens).ToListAsync();
            var user = allUsers.SingleOrDefault(u => u.RefreshTokens.SingleOrDefault(r => r.Token == refreshToken).Token == refreshToken);
            //var user = await _context.Users.FirstOrDefaultAsync(u => u.RefreshTokens.Where(r => r.Token == refreshToken);
            return user;
        }

        public async Task<IEnumerable<string>> GetUserRoles(User user) => await _context.UserRoles.Include(ur => ur.Roles).Where(ur => ur.UserId == user.Id).Select(ur => ur.Roles.Name).ToListAsync();
    }
}
