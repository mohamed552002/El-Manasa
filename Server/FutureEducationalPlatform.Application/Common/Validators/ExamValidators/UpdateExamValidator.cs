using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.ExamValidators
{
    public class UpdateExamValidator:AbstractValidator<UpdateExamRequest>
    {
        public UpdateExamValidator()
        {
            RuleFor(er => er.UpdateExamDto).SetValidator(new BaseExamValidator());
        }
    }
}
