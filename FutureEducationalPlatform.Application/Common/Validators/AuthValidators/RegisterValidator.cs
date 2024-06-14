using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class RegisterValidator : AbstractValidator<CreateUserDto>
    {
        public RegisterValidator()
        {
            RuleFor(r => r.Email).EmailAddress().WithMessage("Please enter valid email");
            RuleFor(r => r.Password)
                   .NotEmpty().WithMessage("Password must not be empty")
                   .MinimumLength(8).WithMessage("Password must be at least 8 characters long")
                   .Matches(@"[A-Z]").WithMessage("Password must contain at least one uppercase letter")
                   .Matches(@"[a-z]").WithMessage("Password must contain at least one lowercase letter")
                   .Matches(@"[0-9]").WithMessage("Password must contain at least one number")
                   .Matches(@"[\W_]").WithMessage("Password must contain at least one special character");
            AddNameRule(r => r.FirstName, "FirstName");
            AddNameRule(r => r.LastName, "LastName");
            AddNameRule(r => r.UserName, "UserName");
            RuleFor(r => r.Gender)
                .IsInEnum()
                .WithMessage("Invalid value gender");
        }
        private void AddNameRule(Expression<Func<CreateUserDto, string>> expression, string fieldName)
        {
            RuleFor(expression)
                .Length(2, 16)
                .WithMessage($"{fieldName} must be between 2 and 16 characters in length.");
        }
    }
}
