using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterValidators
{
    public class CreateCenterValidator:AbstractValidator<CreateCenterRequest>
    {
        public CreateCenterValidator()
        {
            RuleFor(r => r.CreateCenterDto).SetValidator(new BaseValidator());
        }
    }
}
