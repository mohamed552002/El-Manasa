using FutureEducationalPlatform.Domain.Enums;

namespace FutureEducationalPlatform.Application.DTOS.CourseDtos
{
    public record BaseCourseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GradeLevel Level { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
