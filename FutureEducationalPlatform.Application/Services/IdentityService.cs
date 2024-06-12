using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<User> _baseRepository;
        private readonly IPasswordService _passwordService;
        public IdentityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _baseRepository = _unitOfWork.GetRepository<User>();
        }

        public Task<User> GetByEmailAsync(string email)
        {
            return _baseRepository.FirstOrDefaultAsync(u => u.Email == email);
        }
        public Task<User> GetByUserNameAsync(string userName)
        {
            return _baseRepository.FirstOrDefaultAsync(u => u.UserName == userName);
        }

        public async Task<User> CreateUser(User user,string password)
        {
            user.PasswordHash = _passwordService.HashPassword(password);
            return await _baseRepository.AddWithReturnAsync(user);
        }
        public async Task<User> UpdateUser(User user)
        {
           var result = _baseRepository.Update(user);
           await _unitOfWork.CompleteAsync();
            return result;
        }

    }
}
