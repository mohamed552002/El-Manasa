using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseValidators
{
    public class UpdateCourseValidator:AbstractValidator<UpdateCourseRequest>
    {
        public UpdateCourseValidator()
        {
            RuleFor(ur => ur.UpdateCourseDto).SetValidator(new BaseCourseValidator());
        }
    }
}
