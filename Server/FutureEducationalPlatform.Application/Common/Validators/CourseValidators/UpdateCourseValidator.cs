using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseValidators
{
    public class UpdateCourseValidator:AbstractValidator<UpdateCourseRequest>
    {
        public UpdateCourseValidator()
        {
            RuleFor(x => x.UpdateCourseDto).SetValidator(new BaseCourseValidator());
        }
    }
}
