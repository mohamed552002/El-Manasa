using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
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
    public class RegisterValidator : BaseAuthValidator<RegisterRequest>
    {
        public RegisterValidator():base(r=>r.CreateUserDto.Password)
        {
            RuleFor(r => r.CreateUserDto.Email).EmailAddress().WithMessage("Please enter valid email");
            AddNameRule(r => r.CreateUserDto.FirstName, "FirstName");
            AddNameRule(r => r.CreateUserDto.LastName, "LastName");
            AddNameRule(r => r.CreateUserDto.UserName, "UserName");
            RuleFor(r => r.CreateUserDto.Gender)
                .IsInEnum()
                .WithMessage("Invalid value gender");
        }
        private void AddNameRule(Expression<Func<RegisterRequest, string>> expression, string fieldName)
        {
            RuleFor(expression)
                .Length(2, 16)
                .WithMessage($"{fieldName} must be between 2 and 16 characters in length.");
        }
    }
}
