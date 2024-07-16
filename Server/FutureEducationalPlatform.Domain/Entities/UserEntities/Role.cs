using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class Role:BaseModel
    {
        public string Name { get; set; }
        public virtual IEnumerable<UserRoles> Users { get; set;}
    }
}
