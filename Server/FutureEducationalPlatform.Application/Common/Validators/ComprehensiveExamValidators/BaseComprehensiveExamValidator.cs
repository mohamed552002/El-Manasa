using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;

namespace FutureEducationalPlatform.Application.Common.Validators.ComprehensiveExamValidators
{
    public class BaseComprehensiveExamValidator : AbstractValidator<BaseComprehensiveExamDto>
    {
        public BaseComprehensiveExamValidator()
        {
            RuleFor(r => r.Name).NotEmpty().NotNull().MaximumLength(64).WithMessage("لا يمكن ان يتجاوز اسم الامتحان الشامل 120 حرف");
            RuleFor(r => r.Description).NotEmpty().NotNull().MaximumLength(512).WithMessage("لا يمكن ان يتجاوز الوصف 500 حرف");
            RuleFor(r => r.StartDate).GreaterThan(DateTime.UtcNow).WithMessage("لا يمكن اضافة تاريخ ابتداء الامتحان الشامل في الماضي");
            RuleFor(r => r.EndDate).GreaterThan(r => r.StartDate).WithMessage("لا يمكن ان يكون تاريخ انتهاء الامتحان الشامل قبل تاريخ بدايته");
        }
    }
}
