using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Exceptions;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Application.Services;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class LoginHandler :  IRequestHandler<LoginRequest, AuthModel>
    {
        private readonly JwtService _jwtService;
        private readonly IIdentityService _identityService;
        public LoginHandler(  JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        public async Task<AuthModel> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var user = await _identityService.GetByEmailAsync(request.LoginDto.Email);
            if (user == null || !_identityService.VerifyPassword(request.LoginDto.Password, user.PasswordHash) || !user.EmailConfirmed)
                throw new ValidationErrorException("Wrong Email Or Password");
            var jwtSecurityToken = (await _jwtService.GenerateToken(user)).ToString();
            var userRoles = (await _identityService.GetUserRoles(user)).Select(r => r.Roles.Name);
            var refreshToken = _jwtService.AssignRefreshTokenToUser(user);
            return new AuthModel(user, refreshToken, userRoles,jwtSecurityToken);

        }
    }
}
