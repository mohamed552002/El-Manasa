using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
