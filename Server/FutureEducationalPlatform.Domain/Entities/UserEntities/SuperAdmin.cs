using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class SuperAdmin:BaseModel
    {
        public string ImgUrl { get; set; } 
        public User User { get; set; }
    }
}
