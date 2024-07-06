using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Domain.Entities.HomeworkEntites
{
    public class Homework : BaseModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
