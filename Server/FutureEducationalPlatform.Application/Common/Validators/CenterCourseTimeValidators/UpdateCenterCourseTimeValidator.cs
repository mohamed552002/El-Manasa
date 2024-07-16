using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterCourseTimeValidators
{
    public class UpdateCenterCourseTimeValidator:AbstractValidator<UpdateCenterCourseTimeRequest>
    {
        public UpdateCenterCourseTimeValidator()
        {
            RuleFor(r => r.UpdateCenterCourseTimeDto).SetValidator(new BaseCenterCourseTimeValidator());
        }
    }
}
