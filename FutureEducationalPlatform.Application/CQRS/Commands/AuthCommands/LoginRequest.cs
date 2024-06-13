using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
