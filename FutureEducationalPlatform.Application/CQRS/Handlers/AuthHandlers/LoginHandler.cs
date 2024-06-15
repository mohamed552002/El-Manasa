using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Common.Validators.AuthValidators;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;

using MediatR;

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
            var user = await _identityService.GetByEmailAsync(request.LoginDto.Email);
            if (user == null || !_identityService.VerifyPassword(request.LoginDto.Password, user.PasswordHash) || !user.EmailConfirmed)
                throw new BadRequestException("Wrong email or password");
            return await _jwtService.GetAuthModel(user);
        }
    }
}
