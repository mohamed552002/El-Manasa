using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands;

namespace FutureEducationalPlatform.Application.Common.Validators.ComprehensiveExamValidators
{
    public class UpdateComprehensiveExamValidator : AbstractValidator<UpdateComprehensiveExamRequest>
    {
        public UpdateComprehensiveExamValidator()
        {
            RuleFor(ch => ch.UpdateComprehensiveExamDto).SetValidator(new BaseComprehensiveExamValidator());
        }
    }
}
