using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseSectionValidators
{
    public class UpdateCourseSectionValidator:AbstractValidator<UpdateCourseSectionRequest>
    {
        public UpdateCourseSectionValidator()
        {
            RuleFor(r=>r.UpdateCourseSectionDto)
                .SetValidator(new BaseCourseSectionValidator());
        }
    }
}
