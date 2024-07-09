using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;

namespace FutureEducationalPlatform.Domain.Entities.ExamEntities
{
    public class ExamQuestion:BaseModel
    {
        public Guid ExamId { get; set; }
        public Guid QuestionId { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Question Question { get; set; }
    }
}
