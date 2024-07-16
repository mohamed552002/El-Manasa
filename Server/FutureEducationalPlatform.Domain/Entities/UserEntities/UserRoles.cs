using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class UserRoles:BaseModel
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public User User { get; set; }
        public Role Roles { get; set; }
    }
}
