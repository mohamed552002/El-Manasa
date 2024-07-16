using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class Admin:BaseModel
    {
        public string ImageUrl { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }= DateTime.Now;
        public virtual User User { get; set; }
    }
}
