﻿using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;

namespace FutureEducationalPlatform.Domain.Entities.CenterEntites
{
    public class CenterCourseTime:BaseModel
    {
        public Guid CenterId { get; set; }
        public Guid CourseId { get; set; }
        public DayOfWeek LectureDay { get; set; }
        public TimeOnly LectureTime { get; set; }
        public virtual Course Course { get; set; }
        public virtual Center Center { get; set; }
    }
}
