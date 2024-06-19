using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterCourseTimeValidators
{
    public class UpdateCenterCourseTimeValidator:AbstractValidator<UpdateCenterCourseTimeRequest>
    {
        public UpdateCenterCourseTimeValidator()
        {
            RuleFor(r=>r.UpdateCenterCourseTimeDto.CenterId).NotEmpty().NotNull().WithMessage("يرجي ادخال رقم السنتر");
            RuleFor(r=>r.UpdateCenterCourseTimeDto.CourseId).NotEmpty().NotNull().WithMessage("يرجي ادخال رقم الكورس");
            RuleFor(r => r.UpdateCenterCourseTimeDto.LectureDay).NotEmpty().NotNull().IsInEnum().WithMessage("لا يوجد يوم بهذه القيمه");
            RuleFor(r => r.UpdateCenterCourseTimeDto.LectureTime).NotEmpty().NotNull().WithMessage("يرجي ادخال ميعاد المحاضره");
        }
    }
}
