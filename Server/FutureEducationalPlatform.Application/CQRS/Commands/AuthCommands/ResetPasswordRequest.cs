using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands
{
    public class ResetPasswordRequest : IRequest<string>
    {
        public ResetPasswordDto ResetPasswordDto { get; }
        public ResetPasswordRequest(ResetPasswordDto resetPasswordDto)
        {
            ResetPasswordDto = resetPasswordDto;
        }
    }
}
