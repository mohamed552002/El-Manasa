using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;

namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class VerifyAccountDtoValidator:AbstractValidator<VerifyAccountRequest>
    {
        public VerifyAccountDtoValidator()
        {
            RuleFor(r => r.VerifyAccountDto.Email).EmailAddress().WithMessage("يرجي ادخال بريد الكتروني صحيح");
            RuleFor(r => r.VerifyAccountDto.VerificationCode)
                .Length(6)
                .WithMessage("يرجي ادخال رمز تحقق صالح");
        }
    }
}
