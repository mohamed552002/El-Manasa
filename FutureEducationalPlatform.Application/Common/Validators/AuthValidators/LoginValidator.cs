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
    public class LoginValidator : AbstractValidator<LoginRequest>
    {
        public LoginValidator()
        {
            RuleFor(le => le.LoginDto.Email).EmailAddress().WithMessage("Please enter valid email").NotEmpty();
            RuleFor(lp => lp.LoginDto.Password)
                    .NotEmpty().WithMessage("Password must not be empty")
                    .MinimumLength(8).WithMessage("Password must be at least 8 characters long")
                    .Matches(@"[A-Z]").WithMessage("Password must contain at least one uppercase letter")
                    .Matches(@"[a-z]").WithMessage("Password must contain at least one lowercase letter")
                    .Matches(@"[0-9]").WithMessage("Password must contain at least one number")
                    .Matches(@"[\W_]").WithMessage("Password must contain at least one special character");
        }
    }
}
