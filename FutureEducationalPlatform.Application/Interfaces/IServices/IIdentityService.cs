using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Interfaces.IServices
{
    public interface IIdentityService : IBaseService<User, GetUserDto, CreateUserDto, UpdateUserDto>
    {
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByUserNameAsync(string userName);
        Task<User> GetByRefreshTokenAsync(string refreshToken);
        Task<User> CreateUser(CreateUserDto userDto);
        bool VerifyPassword(string password,string passwordHash);
        Task<IEnumerable<string>> GetUserRoles(User user);
        Task<User> UpdateUser(User user);
        Task ChangePassword(User user, string oldPassword, string newPassword);
    }
}
