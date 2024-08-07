﻿using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseSectionValidators
{
    public class CreateCourseSectionValidator:AbstractValidator<CreateCourseSectionRequest>
    {
        public CreateCourseSectionValidator()
        {
            RuleFor(r=>r.CreateCourseSectionDto)
                .SetValidator(new BaseCourseSectionValidator());
            RuleFor(r => r.CreateCourseSectionDto.StartDate)
             .GreaterThan(DateTime.UtcNow)
             .WithMessage("لا يمكن اضافة تاريخ ابتداء هذا الجزء في الماضي");
        }
    }
}
