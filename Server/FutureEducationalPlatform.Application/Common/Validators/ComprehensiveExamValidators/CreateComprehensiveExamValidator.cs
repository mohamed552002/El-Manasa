using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.ComprehensiveExamValidators
{
    public class CreateComprehensiveExamValidator : AbstractValidator<CreateComprehensiveExamRequest>
    {
        public CreateComprehensiveExamValidator()
        {
            RuleFor(ch => ch.CreateComprehensiveExamDto).SetValidator(new BaseComprehensiveExamValidator());
        }
    }
}
