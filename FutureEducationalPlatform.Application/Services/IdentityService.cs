using AutoMapper;
using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Common.HelperMethods;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.UserEntities;

namespace FutureEducationalPlatform.Application.Services
{
    public class IdentityService : BaseService<User, GetUserDto, CreateUserDto, UpdateUserDto>, IIdentityService
    {
        private readonly IPasswordService _passwordService;
        private readonly IEmailSender _emailSender;
        public IdentityService(IMapper mapper, IUnitOfWork unitOfWork, IPasswordService passwordService, IEmailSender emailSender) : base(mapper, unitOfWork)
        {
            _passwordService = passwordService;
            _emailSender = emailSender;
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
            user.LastUpdatedAt = DateTime.UtcNow;
            var result =_baseRepository.Update(user);
            await _unitOfWork.CompleteAsync();
            return result;
        }
        public bool VerifyPassword(string password, string passwordHash)
        {
            return _passwordService.VerifyPassword(password, passwordHash);
        }
        public void SendForgetPasswordOTP(string email)
        {
            var code = RandomCodeGenerator.GenerateRandomCode();
            _emailSender.SendEmail(email, "Reset Password OTP", $"Your OTP Is: {code}");
        }
        public async Task ChangePassword(User user,string oldPassword,string newPassword)
        {
            var passwordVerfication = _passwordService.VerifyPassword(oldPassword, user.PasswordHash);
            if (!passwordVerfication)
                throw new BadRequestException("Old Password is wrong");
            user.PasswordHash = _passwordService.HashPassword(newPassword);
            await UpdateUser(user);
        }
        public Task<IEnumerable<string>> GetUserRoles(User user)
        {
            return _unitOfWork.UserRepository.GetUserRoles(user);
        }
        public async Task AddToRoleAsync(User user, string roleName)
        {
            await _unitOfWork.UserRepository.AddToRoleAsync(user, roleName);
            await _unitOfWork.CompleteAsync();
        }
    }
}
