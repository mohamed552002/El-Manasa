using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.StudentQuestionAnswerValidators
{
    public class UpdateStudentQuestionAnswerValidator:AbstractValidator<UpdateStudentQuestionAnswerRequest>
    {
        public UpdateStudentQuestionAnswerValidator()
        {
            RuleFor(sqar=>sqar.UpdateStudentQuestionAnswerDto).SetValidator(new BaseStudentQuestionAnswerValidator());
        }
    }
}
