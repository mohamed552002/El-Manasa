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
    public class RoleRepository: IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<string>> GetUserRoles(User user) => await _context.UserRoles.Include(ur => ur.Roles).Where(ur => ur.UserId == user.Id).Select(ur => ur.Roles.Name).ToListAsync();
        public async Task AddToRoleAsync(User user, string roleName)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name.ToLower().Trim() == roleName.ToLower().Trim());
            await _context.UserRoles.AddAsync(new UserRoles { UserId = user.Id, RoleId = role.Id });
        }
    }
}
