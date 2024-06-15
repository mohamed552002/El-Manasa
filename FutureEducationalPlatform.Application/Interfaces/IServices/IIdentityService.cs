using FutureEducationalPlatform.Application.DTOS.AuthDtos;
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
        Task<User> CreateUser(CreateUserDto userDto);
        Task<User> UpdateUser(User user);
        bool VerifyPassword(string password,string passwordHash);
        Task<IEnumerable<string>> GetUserRoles(User user);
        Task ChangePassword(User user, string oldPassword, string newPassword);
        Task AddToRoleAsync(User user, string roleName);
        Task<User> UpdateUser(User user);
    }
}
