using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterCourseTimeValidators
{
    public class CreateCenterCourseTimeValidators : AbstractValidator<CreateCenterCourseTimeRequest>
    {
        public CreateCenterCourseTimeValidators()
        {
            RuleFor(r => r.AddCenterCourseTimeDto.CenterId).NotEmpty().NotNull().WithMessage("يرجي ادخال رقم السنتر");
            RuleFor(r => r.AddCenterCourseTimeDto.CourseId).NotEmpty().NotNull().WithMessage("يرجي ادخال رقم الكورس");
            RuleFor(r => r.AddCenterCourseTimeDto.LectureDay).NotEmpty().NotNull().IsInEnum().WithMessage("لا يوجد يوم بهذه القيمه");
            RuleFor(r => r.AddCenterCourseTimeDto.LectureTime).NotEmpty().NotNull().WithMessage("يرجي ادخال ميعاد المحاضره");
        }
    }
}
