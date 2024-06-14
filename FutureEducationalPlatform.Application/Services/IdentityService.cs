using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Exceptions;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Services
{
    public class IdentityService : BaseService<User, GetUserDto, CreateUserDto, UpdateUserDto>, IIdentityService
    {
        private readonly IPasswordService _passwordService;
        public IdentityService(IMapper mapper, IUnitOfWork unitOfWork, IPasswordService passwordService) : base(mapper, unitOfWork)
        {
            _passwordService = passwordService;
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
        public bool VerifyPassword(string password, string passwordHash)
        {
            return _passwordService.VerifyPassword(password, passwordHash);
        }
        public async Task ChangePassword(User user,string oldPassword,string newPassword)
        {
            var passwordVerfication = _passwordService.VerifyPassword(oldPassword, user.PasswordHash);
            if (!passwordVerfication)
                throw new BadRequestException("Old Password is wrong");
            user.PasswordHash = _passwordService.HashPassword(newPassword);
            _baseRepository.Update(user);
            await _unitOfWork.CompleteAsync();
        }
        public Task<IEnumerable<string>> GetUserRoles(User user)
        {
            return _unitOfWork.UserRepository.GetUserRoles(user);
        }

        public Task<User> GetByRefreshTokenAsync(string refreshToken)
        {
            throw new NotImplementedException();
        }

    }
}
