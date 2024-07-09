using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.ExamQuestionValidators
{
    public class CreateExamQuestionValidator:AbstractValidator<CreateExamQuestionRequest>
    {
        public CreateExamQuestionValidator()
        {
            RuleFor(eqr=>eqr.CreateExamQuestionDto).SetValidator(new BaseExamQuestionValidator());
        }
    }
}
