using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;

namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class UserEmailDtoValidator:AbstractValidator<ResendVerificationCodeRequest>
    {
        public UserEmailDtoValidator()
        {
            RuleFor(r => r.UserEmailDto.Email).EmailAddress().WithMessage("يرجي ادخال بريد الكتروني صحيح");
        }
    }
}
