using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.ExamQuestionDtos;

namespace FutureEducationalPlatform.Application.Common.Validators.ExamQuestionValidators
{
    public class BaseExamQuestionValidator:AbstractValidator<BaseExamQuestionDto>
    {
        public BaseExamQuestionValidator()
        {
            RuleFor(eq => eq.QuestionId).NotEmpty().NotNull().WithMessage("يجب ادخال رقم السؤال");
            RuleFor(eq => eq.ExamId).NotEmpty().NotNull().WithMessage("يجب ادخال رقم الاختبار");
        }
    }
}
