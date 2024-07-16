using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterCourseTimeValidators
{
    public class BaseCenterCourseTimeValidator : AbstractValidator<BaseCenterCourseTimeDto>
    {
        public BaseCenterCourseTimeValidator()
        {
            RuleFor(cct => cct.CenterId).NotEmpty().NotNull().WithMessage("يرجي ادخال رقم السنتر");
            RuleFor(cct => cct.CourseId).NotEmpty().NotNull().WithMessage("يرجي ادخال رقم الكورس");
            RuleFor(cct => cct.LectureDay).NotEmpty().NotNull().IsInEnum().WithMessage("لا يوجد يوم بهذه القيمه");
            RuleFor(cct => cct.LectureTime).NotEmpty().NotNull().WithMessage("يرجي ادخال ميعاد المحاضره");
        }
    }
}
