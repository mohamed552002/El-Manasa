using FutureEducationalPlatform.Domain.Entities.AuthEntites;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Interfaces.IServices
{
    public interface IJwtService
    {
        Task<JwtSecurityToken> GenerateToken(User user);
        Task<RefreshToken> AssignRefreshTokenToUser(User user);
        RefreshToken GenerateRefreshToken();
    }
}
