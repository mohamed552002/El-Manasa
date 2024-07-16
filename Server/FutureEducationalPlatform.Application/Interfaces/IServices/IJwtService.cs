using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Domain.Entities.AuthEntites;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using System.IdentityModel.Tokens.Jwt;

namespace FutureEducationalPlatform.Application.Interfaces.IServices
{
    public interface IJwtService
    {
        Task<JwtSecurityToken> GenerateToken(User user);
        Task<RefreshToken> AssignRefreshTokenToUser(User user);
        RefreshToken GenerateRefreshToken();
        Task<AuthModel> GetAuthModel(User user);
    }
}
