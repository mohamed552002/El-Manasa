using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.StudentQuestionAnswerValidators
{
    public class CreateStudentQuestionAnswerValidator:AbstractValidator<CreateStudentQuestionAnswerRequest>
    {
        public CreateStudentQuestionAnswerValidator()
        {
            RuleFor(sqar=>sqar.CreateStudentQuestionAnswerDto).SetValidator(new BaseStudentQuestionAnswerValidator());
            RuleFor(sqar => sqar.CreateStudentQuestionAnswerDto.AnsweredAt).NotEmpty().NotNull().GreaterThanOrEqualTo(DateTime.Now).WithMessage("لا يمكن ان يكون تاريخ اضافة الاجابه في الماضي");
        }
    }
}
