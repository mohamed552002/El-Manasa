
using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;

namespace FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities
{
    public class ComprehensiveExam : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsActive { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }

    }
}
