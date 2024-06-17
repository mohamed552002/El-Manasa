using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseValidators
{
    public class UpdateCourseValidator:AbstractValidator<UpdateCourseRequest>
    {
        public UpdateCourseValidator()
        {
            RuleFor(r => r.UpdateCourseDto.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(64)
                .WithMessage("لا يمكن ان يتجاوز الاسم 60 حرف");
            RuleFor(r => r.UpdateCourseDto.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(512)
                .WithMessage("لا يمكن ان يتجاوز الوصف 500 حرف");
            RuleFor(r => r.UpdateCourseDto.StartDate)
                .GreaterThan(DateTime.UtcNow)
                .WithMessage("لا يمكن اضافة تاريخ ابتداء الدورة في الماضي");
            RuleFor(r => r.UpdateCourseDto.EndDate)
                .GreaterThan(r => r.UpdateCourseDto.StartDate)
                .WithMessage("لا يمكن ان يكون تاريخ انتهاء الدورة قبل تاريخ بدايتها");
            RuleFor(r => r.UpdateCourseDto.Level)
                .IsInEnum()
                .WithMessage("لا توجد سنة دراسية بهذه القيمة");
        }
    }
}
