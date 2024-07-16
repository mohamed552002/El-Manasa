using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class Parent:BaseModel
    {
        public string PhoneNumber { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
