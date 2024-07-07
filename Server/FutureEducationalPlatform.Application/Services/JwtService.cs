﻿using FutureEducationalPlatform.Application.Common.HelperModels;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.AuthEntites;
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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Services
{
    public class JwtService : IJwtService
    {
        private readonly JWT _jwt;
        private readonly IRoleService _roleService;
        private readonly IUserService _userService;
        public JwtService(IOptions<JWT> options, IRoleService roleService, IUserService userService)
        {
            _jwt = options.Value;
            _roleService = roleService;
            _userService = userService;
        }

        public async Task<JwtSecurityToken> GenerateToken(User user)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.SecretKey));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            return new JwtSecurityToken(_jwt.Issuer, _jwt.Audience, await GetAllTokenClaims(user), expires: DateTime.Now.AddMinutes(_jwt.DurationMinutes), signingCredentials: signingCredentials);
        }
        public RefreshToken GenerateRefreshToken()
        {
            var randomNumber = new byte [32];
            using var rng=RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return new RefreshToken() { Token = Convert.ToBase64String(randomNumber)} ;
        }
        private IEnumerable<Claim> GetUserRolesClaims(IEnumerable<string> userRoles)
        {
            var roleClaims = new List<Claim>();
            foreach (var role in userRoles)
                roleClaims.Add(new Claim("roles",role));
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
            .Union( GetUserRolesClaims(await _roleService.GetUserRoles(user)));
        }
        public async Task<RefreshToken> AssignRefreshTokenToUser(User user)
        {
            if (user.RefreshTokens.Any(t => t.IsActive))
                return user.RefreshTokens.FirstOrDefault(r => r.IsActive);
            else
            {
                var refreshToken = GenerateRefreshToken();
                user.RefreshTokens.Add(refreshToken);
                await _userService.Update(user);
                return refreshToken;
            }
        }
        public async Task<AuthModel> GetAuthModel(User user)
        {
            var jwtSecurityToken = await GenerateToken(user);
            var userRoles = await _roleService.GetUserRoles(user);
            var refreshToken = await AssignRefreshTokenToUser(user);
            return new AuthModel(user, refreshToken, userRoles, jwtSecurityToken);
        }
    }
}
