using FutureEducationalPlatform.Domain.Enums;

namespace FutureEducationalPlatform.Application.DTOS.CourseDtos
{
    public record AddCourseDto : BaseCourseDto
    {
        public AddCourseDto(string Name, string Description, GradeLevel Level, bool IsActive, DateTime StartDate, DateTime EndDate) : base(Name, Description, Level, IsActive, StartDate, EndDate)
        { }
    }
}
