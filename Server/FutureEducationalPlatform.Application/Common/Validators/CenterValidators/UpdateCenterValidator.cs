using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterValidators
{
    public class UpdateCenterValidator : AbstractValidator<UpdateCenterRequest>
    {
        public UpdateCenterValidator()
        {
            RuleFor(r => r.UpdateCenterDto).SetValidator(new BaseValidator());
        }
    }
}
