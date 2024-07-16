using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.QuestionDtos;

namespace FutureEducationalPlatform.Application.Common.Validators.QuestionValidators
{
    public class BaseQuestionValidator : AbstractValidator<BaseQuestionDto>
    {
        public BaseQuestionValidator()
        {
            RuleFor(q => q.Text).NotEmpty().NotNull().Length(2,500).WithMessage("يجب ان يكون السؤال بين 2 الي 500 حرف");
            RuleFor(q => q.Type).NotEmpty().NotNull().IsInEnum().WithMessage("هذا النوع من الاسئلة غير موجود");
            RuleFor(q => q.Difficulity).NotEmpty().NotNull().IsInEnum().WithMessage("درجة الصعوبة غير موجودة");
            RuleFor(q => q.Answers).NotEmpty().NotNull().IsInEnum().WithMessage("هذا الاختيار غير موجود من ضمن اختيارات الحل");
            RuleFor(q => q.Grade).NotEmpty().NotNull().InclusiveBetween(0.5,5).WithMessage("يجب ان تتراوح درجة السؤال بين 0.5 درجة الي 5 درجات");
        }
    }
}
