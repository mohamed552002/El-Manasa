using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.StudentQuestionAnswerDtos;

namespace FutureEducationalPlatform.Application.Common.Validators.StudentQuestionAnswerValidators
{
    public class BaseStudentQuestionAnswerValidator:AbstractValidator<BaseStudentQuestionAnswerDto>
    {
        public BaseStudentQuestionAnswerValidator()
        {
            RuleFor(sqa => sqa.QuestionId).NotEmpty().NotNull().WithMessage("يجب ادخال رقم السؤال");
            RuleFor(sqa => sqa.StudentId).NotEmpty().NotNull().WithMessage("يجب ادخال رقم الطالب");
            RuleFor(sqa => sqa.StudentAnswer).NotEmpty().NotNull().IsInEnum().WithMessage("هذا الاختيار غير موجود من ضمن اختيارات الحل");
        }
    }
}
