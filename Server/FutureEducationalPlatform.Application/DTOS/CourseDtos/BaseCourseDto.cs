using FutureEducationalPlatform.Domain.Enums;

namespace FutureEducationalPlatform.Application.DTOS.CourseDtos
{
    public record BaseCourseDto
    (
        string Name,
        string Description,
        GradeLevel Level,
        bool IsActive,
        DateTime StartDate,
        DateTime EndDate
    );
}
