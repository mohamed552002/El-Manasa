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
    public class UserEmailDtoValidator:AbstractValidator<ResendVerificationCodeRequest>
    {
        public UserEmailDtoValidator()
        {
            RuleFor(r => r.UserEmailDto.Email).EmailAddress().WithMessage("Please enter valid email");
        }
    }
}
