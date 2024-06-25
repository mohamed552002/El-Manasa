using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterCourseTimeValidators
{
    public class BaseCenterCourseTimeValidator : AbstractValidator<BaseCenterCourseTimeDto>
    {
        public BaseCenterCourseTimeValidator()
        {
            RuleFor(r => r.CenterId).NotEmpty().NotNull().WithMessage("يرجي ادخال رقم السنتر");
            RuleFor(r => r.CourseId).NotEmpty().NotNull().WithMessage("يرجي ادخال رقم الكورس");
            RuleFor(r => r.LectureDay).NotEmpty().NotNull().IsInEnum().WithMessage("لا يوجد يوم بهذه القيمه");
            RuleFor(r => r.LectureTime).NotEmpty().NotNull().WithMessage("يرجي ادخال ميعاد المحاضره");
        }
    }
}
