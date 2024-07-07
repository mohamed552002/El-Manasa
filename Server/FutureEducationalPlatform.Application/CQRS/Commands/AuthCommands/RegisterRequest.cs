using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
