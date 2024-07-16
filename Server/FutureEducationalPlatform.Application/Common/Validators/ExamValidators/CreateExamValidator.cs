using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.ExamValidators
{
    public class CreateExamValidator:AbstractValidator<CreateExamRequest>
    {
        public CreateExamValidator()
        {
            RuleFor(er=>er.CreateExamDto).SetValidator(new BaseExamValidator());
        }
    }
}
