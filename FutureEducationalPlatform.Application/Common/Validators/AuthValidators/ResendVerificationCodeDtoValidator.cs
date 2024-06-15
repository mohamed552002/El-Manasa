using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class ResendVerificationCodeDtoValidator:AbstractValidator<ResendVerificationCodeDto>
    {
        public ResendVerificationCodeDtoValidator()
        {
            RuleFor(r => r.Email).EmailAddress().WithMessage("Please enter valid email");
        }
    }
}
