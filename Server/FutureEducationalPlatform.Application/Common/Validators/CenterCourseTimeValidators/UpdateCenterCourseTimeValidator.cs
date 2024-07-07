using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterCourseTimeValidators
{
    public class UpdateCenterCourseTimeValidator:AbstractValidator<UpdateCenterCourseTimeRequest>
    {
        public UpdateCenterCourseTimeValidator()
        {
            RuleFor(c => c.UpdateCenterCourseTimeDto).SetValidator(new BaseCenterCourseTimeValidator());
        }
    }
}
