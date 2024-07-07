using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.ExamDtos;

namespace FutureEducationalPlatform.Application.Common.Validators.ExamValidators
{
    public class BaseExamValidator:AbstractValidator<BaseExamDto>
    {
        public BaseExamValidator()
        {
            RuleFor(e => e.Name)
              .NotEmpty()
              .NotNull()
              .Length(2, 128)
              .WithMessage("يجب ان يكون اسم الاختبار بين 2 الي 128 حرف");
        }
    }
}
