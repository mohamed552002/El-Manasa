using FutureEducationalPlatform.Application.DTOS.UserDtos;
using MediatR;


namespace FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands
{
    public class RegisterRequest:IRequest<string>
    {
        public CreateUserDto CreateUserDto { get; }

        public RegisterRequest(CreateUserDto createUserDto)
        {
            CreateUserDto = createUserDto;
        }
    }
}
