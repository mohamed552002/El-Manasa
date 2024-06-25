using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
