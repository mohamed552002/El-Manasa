using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using FutureEducationalPlatform.Domain.Entities.StudentQuestionAnswerEntites;
using FutureEducationalPlatform.Domain.Enums;

namespace FutureEducationalPlatform.Domain.Entities.QuestionEntites
{
    public class Question : BaseModel
    {
        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public QuestionDifficulity Difficulity { get; set; }
        public QuestionAnswers Answers { get; set; }
        public double Grade { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<ExamQuestion> Exams { get; set; }
        public virtual ICollection<StudentQuestionAnswer> StudentsAnswers { get; set; }
    }
}
