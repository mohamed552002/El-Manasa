using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;

namespace FutureEducationalPlatform.Persistence.Repositories
{
    public class RoleRepository: BaseRepository<UserRoles> ,IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context) { }
        public async Task<IEnumerable<string>> GetUserRoles(User user) => await _context.UserRoles.Include(ur => ur.Roles).Where(ur => ur.UserId == user.Id).Select(ur => ur.Roles.Name).ToListAsync();
        public async Task AddToRoleAsync(User user, string roleName)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name.ToLower().Trim() == roleName.ToLower().Trim());
            if(role != null && !await _context.Users.AnyAsync(u => u.Id == user.Id))
                throw new EntityNotFoundException("الدور او المستخدم غير موجودين");
            if (!await IsExist(ur => ur.UserId == user.Id) && !await IsExist(ur => ur.RoleId == role.Id))
                throw new BadRequestException("هذا المستخدم مضاف يقوم بهذا الدور بالفعل");
                await _context.UserRoles.AddAsync(new UserRoles { UserId = user.Id, RoleId = role.Id });
        }
    }
}
