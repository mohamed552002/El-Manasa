using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.ExamQuestionValidators
{
    public class UpdateExamQuestionValidator:AbstractValidator<UpdateExamQuestionRequest>
    {
        public UpdateExamQuestionValidator()
        {
            RuleFor(eqr=>eqr.UpdateExamQuestionDto).SetValidator(new BaseExamQuestionValidator());
        }
    }
}
