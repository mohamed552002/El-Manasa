using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
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
    public class UserService:IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IPasswordService _passwordService;
        private readonly IBaseRepository<User> _baseRepository;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IPasswordService passwordService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _passwordService = passwordService;
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

        public async Task<User> Create(CreateUserDto userDto)
        {
            userDto.PasswordHash = _passwordService.HashPassword(userDto.Password);
            return await _baseRepository.AddWithReturnAsync(_mapper.Map<User>(userDto));
        }
        public async Task<User> Update(User user)
        {
            user.LastUpdatedAt = DateTime.UtcNow;
            var result = _baseRepository.Update(user);
            await _unitOfWork.CompleteAsync();
            return result;
        }

        public async Task<User> GetUserByRefreshTokenAsync(string refreshToken)
        {
            return await _unitOfWork.UserRepository.GetUserByRefreshTokenAsync(refreshToken);
        }
    }
}
