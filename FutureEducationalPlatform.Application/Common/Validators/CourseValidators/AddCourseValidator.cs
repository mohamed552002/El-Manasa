using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseValidators
{
    public class AddCourseValidator : AbstractValidator<AddCourseRequest>
    {
        public AddCourseValidator()
        {
            RuleFor(r => r.addCourseDto).SetValidator(new BaseCourseValidator());
        }
    }
}
