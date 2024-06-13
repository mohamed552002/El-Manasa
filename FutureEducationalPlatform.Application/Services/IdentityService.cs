using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Services
{
    public class IdentityService :BaseService<User,GetUserDto,CreateUserDto,UpdateUserDto>, IIdentityService
    {
        private readonly IPasswordService _passwordService;
        public IdentityService(IUnitOfWork unitOfWork,IMapper mapper) : base(mapper,unitOfWork)
        {
        }

        public Task<User> GetByEmailAsync(string email)
        {
            return _baseRepository.FirstOrDefaultAsync(u => u.Email == email);
        }
        public Task<User> GetByUserNameAsync(string userName)
        {
            return _baseRepository.FirstOrDefaultAsync(u => u.UserName == userName);
        }

        public async Task<User> CreateUser(CreateUserDto userDto)
        {
            userDto.PasswordHash = _passwordService.HashPassword(userDto.Password);
            var user = await CreateWithReturnAsync(userDto);
            return user;
        }
        public async Task<User> UpdateUser(User user)
        {
           var result = _baseRepository.Update(user);
           await _unitOfWork.CompleteAsync();
            return result;
        }
        public async Task<IEnumerable<UserRoles>> GetUserRoles(User user) => await _unitOfWork.GetRepository<UserRoles>().GetAllAsync((r => r.UserId == user.Id), u => u.Include(u => u.Roles));
        public bool VerifyPassword(string password, string passwordHash)
        {
            return _passwordService.VerifyPassword(password, passwordHash);
        }
    }
}
