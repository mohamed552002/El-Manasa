using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using FutureEducationalPlatform.Domain.Enums;

namespace FutureEducationalPlatform.Domain.Entities.StudentQuestionAnswerEntites
{
    public class StudentQuestionAnswer:BaseModel
    {
        public Guid StudentId { get; set; }
        public Guid QuestionId { get; set; }
        public QuestionAnswers StudentAnswer { get; set; }
        public DateTime AnsweredAt { get; set; } 
        public virtual Student Student { get; set; }
        public virtual Question Question { get; set; }
    }
}
