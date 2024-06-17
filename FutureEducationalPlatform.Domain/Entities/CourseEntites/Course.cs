using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using FutureEducationalPlatform.Domain.Enums;

namespace FutureEducationalPlatform.Domain.Entities.CourseEntites
{
    public class Course : BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GradeLevel Level { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<CenterCourseTime> Centers { get; set; }
    }
}
