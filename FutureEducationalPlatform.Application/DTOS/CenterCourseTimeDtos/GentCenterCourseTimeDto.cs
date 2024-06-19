using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos
{
    public record GentCenterCourseTimeDto
        (
            DayOfWeek LectureDay,
            TimeSpan LectureTime
        );
}
