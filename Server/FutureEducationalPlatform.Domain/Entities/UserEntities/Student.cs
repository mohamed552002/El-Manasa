using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class Student : BaseModel
    {
        public int GradeLevel { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Guid ParentId { get; set; }
        public virtual Parent Parent { get; set; }
        public User User { get; set; }
    }
}
