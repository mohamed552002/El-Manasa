using FluentValidation;

namespace FutureEducationalPlatform.Application.Common.Validators.CourseValidators
{
    public class CreateCourseValidator : AbstractValidator<CreateCourseRequest>
    {
        public CreateCourseValidator()
        {
            RuleFor(cr => cr.CreateCourseDto).SetValidator(new BaseCourseValidator());
            RuleFor(cr => cr.CreateCourseDto.StartDate).GreaterThan(DateTime.UtcNow).WithMessage("لا يمكن اضافة تاريخ ابتداء الدورة في الماضي");
        }
    }
}
