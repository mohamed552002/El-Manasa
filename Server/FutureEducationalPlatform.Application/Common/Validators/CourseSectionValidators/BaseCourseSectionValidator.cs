using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseSectionValidators
{
    public class BaseCourseSectionValidator:AbstractValidator<BaseCourseSectionDto>
    {
        public BaseCourseSectionValidator()
        {
            RuleFor(cs => cs.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(64)
                .WithMessage("لا يمكن ان يتجاوز الاسم 60 حرف");
            RuleFor(cs => cs.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(512)
                .WithMessage("لا يمكن ان يتجاوز الوصف 500 حرف");
            RuleFor(cs => cs.EndDate)
                .GreaterThan(cs => cs.StartDate)
                .WithMessage("لا يمكن ان يكون تاريخ انتهاء هذا الجزء قبل تاريخ بدايته");
        }
    }
}
