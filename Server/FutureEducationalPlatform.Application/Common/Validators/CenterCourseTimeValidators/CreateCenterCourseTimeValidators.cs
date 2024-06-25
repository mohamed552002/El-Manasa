using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterCourseTimeValidators
{
    public class CreateCenterCourseTimeValidators : AbstractValidator<CreateCenterCourseTimeRequest>
    {
        public CreateCenterCourseTimeValidators()
        {
            RuleFor(c => c.AddCenterCourseTimeDto).SetValidator(new BaseCenterCourseTimeValidator());
        }
    }
}
