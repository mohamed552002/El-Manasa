using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using MediatR;
using System.Linq.Expressions;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseValidators
{
    public class BaseCourseValidator : AbstractValidator<BaseCourseDto>  
    {
        public BaseCourseValidator()
        {
            RuleFor(r => r.Name).NotEmpty().NotNull().MaximumLength(64).WithMessage("لا يمكن ان يتجاوز الاسم 60 حرف");
            RuleFor(r => r.Description).NotEmpty().NotNull().MaximumLength(512).WithMessage("لا يمكن ان يتجاوز الوصف 500 حرف");
            RuleFor(r => r.StartDate).GreaterThan(DateTime.UtcNow).WithMessage("لا يمكن اضافة تاريخ ابتداء الدورة في الماضي");
            RuleFor(r => r.EndDate).GreaterThan(r => r.StartDate).WithMessage("لا يمكن ان يكون تاريخ انتهاء الدورة قبل تاريخ بدايتها");
            RuleFor(r => r.Level).IsInEnum().WithMessage("لا توجد سنة دراسية بهذه القيمة");
        }
    }
}
