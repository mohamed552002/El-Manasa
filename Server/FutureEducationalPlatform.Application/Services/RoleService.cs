using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.UserEntities;

namespace FutureEducationalPlatform.Application.Services
{
    public class RoleService:IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<string>> GetUserRoles(User user)
        {
            return _unitOfWork.RoleRepository.GetUserRoles(user);
        }
        public async Task AddToRoleAsync(User user, string roleName)
        {
            await _unitOfWork.RoleRepository.AddToRoleAsync(user, roleName);
            await _unitOfWork.CompleteAsync();
        }
    }
}
