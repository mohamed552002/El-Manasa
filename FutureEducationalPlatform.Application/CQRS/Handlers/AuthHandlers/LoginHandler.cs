using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Exceptions;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Application.Services;
using FutureEducationalPlatform.Application.Validators.AuthValidators;
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
        private readonly IJwtService _jwtService;
        private readonly IIdentityService _identityService;

        public LoginHandler(IJwtService jwtService, IIdentityService identityService)
        {
            _jwtService = jwtService;
            _identityService = identityService;
        }

        public async Task<AuthModel> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var validator = new LoginValidator();
            var result = await validator.ValidateAsync(request.LoginDto);
            if (result.Errors.Any())  throw new ValidationErrorException(result.Errors.Select(e=>e.ErrorMessage).ToArray());
            var user = await _identityService.GetByEmailAsync(request.LoginDto.Email);
            if (user == null || !_identityService.VerifyPassword(request.LoginDto.Password, user.PasswordHash) || !user.EmailConfirmed)
                throw new BadRequestException("Wrong email or password");
            var jwtSecurityToken = (await _jwtService.GenerateToken(user));
            var userRoles = await _identityService.GetUserRoles(user);
            var refreshToken =await _jwtService.AssignRefreshTokenToUser(user);
            return new AuthModel(user, refreshToken, userRoles,jwtSecurityToken);
        }
    }
}
