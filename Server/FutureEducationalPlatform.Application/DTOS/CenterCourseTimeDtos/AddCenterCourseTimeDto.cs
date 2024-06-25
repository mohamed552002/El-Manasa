

namespace FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos
{
    public record AddCenterCourseTimeDto : BaseCenterCourseTimeDto
    {
        public AddCenterCourseTimeDto(Guid CenterId, Guid CourseId, DayOfWeek LectureDay, TimeSpan LectureTime) : base(CenterId, CourseId, LectureDay, LectureTime)
        {
        }
    }
}
