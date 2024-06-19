using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos
{
    public record UpdateCenterCourceDto
    (
        Guid CenterId,
        Guid CourseId,
        DayOfWeek LectureDay,
        TimeSpan LectureTime
    );

}
