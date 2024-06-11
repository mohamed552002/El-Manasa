using FutureEducationalPlatform.Application.HelperModels;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Services
{
    public class JwtService : IJwtService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JWT _jwt;
        public JwtService(IUnitOfWork unitOfWork, IOptions<JWT> options)
        {
            _unitOfWork = unitOfWork;
            _jwt = options.Value;
        }

        public async Task<JwtSecurityToken> GenerateToken(User user)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.SecretKey));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            return new JwtSecurityToken(_jwt.Issuer, _jwt.Audience, await GetAllTokenClaims(user), expires: DateTime.Now.AddMinutes(_jwt.DurationMinutes), signingCredentials: signingCredentials);
        }
        private async Task<IEnumerable<UserRoles>> GetUserRoles(User user) => await _unitOfWork.GetRepository<UserRoles>().GetAllAsync((r => r.UserId == user.Id), u => u.Include(u => u.Roles));
        private IEnumerable<Claim> GetUserRolesClaims(IEnumerable<UserRoles> userRoles)
        {
            var roleClaims = new List<Claim>();
            foreach (var role in userRoles)
                roleClaims.Add(new Claim("roles",role.Roles.Name));
            return roleClaims;
        }

        private async Task<IEnumerable<Claim>> GetAllTokenClaims(User user)
        {
            return new []
            {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim("uid", user.Id.ToString())
            }
            .Union( GetUserRolesClaims(await GetUserRoles(user)));

        }
    }
}
