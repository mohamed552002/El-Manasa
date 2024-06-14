using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class VerifyAccountDtoValidator:AbstractValidator<VerifyAccountDto>
    {
        public VerifyAccountDtoValidator()
        {
            RuleFor(va => va.Email).EmailAddress().WithMessage("Please enter valid email");
            RuleFor(va => va.VerificationCode)
                .Length(6)
                .WithMessage("Please enter valid verificationcode");
        }
    }
}
