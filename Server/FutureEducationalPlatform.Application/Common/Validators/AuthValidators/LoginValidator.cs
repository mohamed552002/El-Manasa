using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;

namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class LoginValidator : BaseAuthValidator<LoginRequest>
    {
        public LoginValidator():base(r=>r.LoginDto.Password)
        {
            RuleFor(le => le.LoginDto.Email).EmailAddress().WithMessage("Please enter valid email").NotEmpty();
        }
    }
}
