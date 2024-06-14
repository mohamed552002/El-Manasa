using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands
{
    public class ResendVerificationCodeRequest:IRequest<string>
    {
        public ResendVerificationCodeDto ResendVerificationCodeDto { get; }

        public ResendVerificationCodeRequest(ResendVerificationCodeDto resendVerificationCodeDto)
        {
            ResendVerificationCodeDto = resendVerificationCodeDto;
        }
    }
}
