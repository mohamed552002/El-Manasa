using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands
{
    public class VerifyAccountRequest:IRequest<AuthModel>
    {
        public VerifyAccountDto VerifyAccountDto { get; }

        public VerifyAccountRequest(VerifyAccountDto verifyAccountDto)
        {
            VerifyAccountDto = verifyAccountDto;
        }
    }
}
