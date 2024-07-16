using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Domain.Entities.UserEntities;

namespace FutureEducationalPlatform.Application.Interfaces.IServices
{
    public interface IUserService
    {
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByUserNameAsync(string userName);
        Task<User> GetUserByRefreshTokenAsync(string refreshToken);
        Task<User> Create(CreateUserDto userDto);
        Task<User> Update(User user);

    }
}
