using FluentValidation;

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
