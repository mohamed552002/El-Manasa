using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands
{
    public class LoginRequest : IRequest<AuthModel>
    {
        public LoginDto LoginDto { get; }
        public LoginRequest(LoginDto loginDto)
        {
            LoginDto = loginDto;
        }
    }
}
