using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.ExamValidators
{
    public class AddExamValidator:AbstractValidator<AddExamRequest>
    {
        public AddExamValidator()
        {
            RuleFor(er=>er.AddExamDto).SetValidator(new BaseExamValidator());
        }
    }
}
