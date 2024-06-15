using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class VerifyAccountDtoValidator:AbstractValidator<VerifyAccountRequest>
    {
        public VerifyAccountDtoValidator()
        {
            RuleFor(r => r.VerifyAccountDto.Email).EmailAddress().WithMessage("Please enter valid email");
            RuleFor(r => r.VerifyAccountDto.VerificationCode)
                .Length(6)
                .WithMessage("Please enter valid verificationcode");
        }
    }
}
