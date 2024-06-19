
namespace FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos
{
    public record AddCenterCourseTimeDto
    (
        Guid CenterId,
        Guid CourseId,
        DayOfWeek LectureDay,
        TimeSpan LectureTime
    );
}
