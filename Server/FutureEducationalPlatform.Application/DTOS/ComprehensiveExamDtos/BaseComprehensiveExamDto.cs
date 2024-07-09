
namespace FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos
{
    public record BaseComprehensiveExamDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsActive { get; set; }
        public Guid CourseId { get; set; }
    };
}
