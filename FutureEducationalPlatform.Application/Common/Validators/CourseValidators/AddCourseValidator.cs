using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;

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
