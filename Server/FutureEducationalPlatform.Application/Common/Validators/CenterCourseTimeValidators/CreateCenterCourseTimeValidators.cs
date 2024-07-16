using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterCourseTimeValidators
{
    public class CreateCenterCourseTimeValidators : AbstractValidator<CreateCenterCourseTimeRequest>
    {
        public CreateCenterCourseTimeValidators()
        {
            RuleFor(r => r.CreateCenterCourseTimeDto).SetValidator(new BaseCenterCourseTimeValidator());
        }
    }
}
