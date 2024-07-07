using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Domain.Entities.ExamEntities
{
    public class Exam:BaseModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
