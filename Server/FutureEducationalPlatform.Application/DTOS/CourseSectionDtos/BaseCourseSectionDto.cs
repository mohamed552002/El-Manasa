
namespace FutureEducationalPlatform.Application.DTOS.CourseSectionDtos
{
    public record BaseCourseSectionDto 
    { 
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CourseId { get; set; }
        public bool IsActive { get; set; }
    } 
}
