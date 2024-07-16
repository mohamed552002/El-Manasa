namespace FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos
{
    public record BaseCenterCourseTimeDto
    {
        public Guid CenterId { get; set;}
        public Guid CourseId { get; set;}
        public DayOfWeek LectureDay { get; set;}
        public TimeOnly LectureTime { get; set;}
    }
}
