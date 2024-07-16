using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands
{
    public class ChangePasswordRequest : IRequest<string>
    {
        public ChangePasswordDto ChangePasswordDto { get;}
        public ChangePasswordRequest(ChangePasswordDto changePasswordDto)
        {
            ChangePasswordDto = changePasswordDto;
        }
    }
}
