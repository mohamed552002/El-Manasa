using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Domain.Entities.CenterEntites
{
    public class Center:BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<CenterCourseTime> Courses { get; set; }
    }
}
