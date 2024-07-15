using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseValidators
{
    public class BaseCourseValidator : AbstractValidator<BaseCourseDto>  
    {
        public BaseCourseValidator()
        {
            RuleFor(c => c.Name).NotEmpty().NotNull().MaximumLength(64).WithMessage("لا يمكن ان يتجاوز الاسم 60 حرف");
            RuleFor(c => c.Description).NotEmpty().NotNull().MaximumLength(512).WithMessage("لا يمكن ان يتجاوز الوصف 500 حرف");
            RuleFor(c => c.EndDate).GreaterThan(c => c.StartDate).WithMessage("لا يمكن ان يكون تاريخ انتهاء الدورة قبل تاريخ بدايتها");
            RuleFor(c => c.Level).IsInEnum().WithMessage("لا توجد سنة دراسية بهذه القيمة");
        }
    }
}
