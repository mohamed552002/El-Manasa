using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseValidators
{
    public class AddCourseValidator : AbstractValidator<AddCourseRequest>
    {
        public AddCourseValidator()
        {
            RuleFor(c => c.addCourseDto.Name).NotEmpty().NotNull().MaximumLength(64).WithMessage("لا يمكن ان يتجاوز الاسم 60 حرف");
            RuleFor(c => c.addCourseDto.Description).NotEmpty().NotNull().MaximumLength(512).WithMessage("لا يمكن ان يتجاوز الوصف 500 حرف");
            RuleFor(c => c.addCourseDto.StartDate).GreaterThan(DateTime.UtcNow).WithMessage("لا يمكن اضافة تاريخ ابتداء الدورة في الماضي");
            RuleFor(c => c.addCourseDto.EndDate).GreaterThan(r => r.addCourseDto.StartDate).WithMessage("لا يمكن ان يكون تاريخ انتهاء الدورة قبل تاريخ بدايتها");
        }
    }
}
