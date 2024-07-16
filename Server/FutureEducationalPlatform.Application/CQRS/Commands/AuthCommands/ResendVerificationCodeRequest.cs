using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands
{
    public class ResendVerificationCodeRequest:IRequest<string>
    {
        public UserEmailDto UserEmailDto { get; }

        public ResendVerificationCodeRequest(UserEmailDto userEmailDto)
        {
            UserEmailDto = userEmailDto;
        }
    }
}
