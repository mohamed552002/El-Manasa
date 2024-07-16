namespace FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos
{
    public record GetCenterCourseTimeDto
        (
            DayOfWeek LectureDay,
            TimeOnly LectureTime
        );
}
