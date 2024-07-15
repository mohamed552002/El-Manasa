using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Entities.StudentQuestionAnswerEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class Student : BaseModel
    {
        public int GradeLevel { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Guid ParentId { get; set; }
        public virtual Parent Parent { get; set; }
        public User User { get; set; }
        public virtual ICollection<StudentQuestionAnswer> QuestionsAnswers { get; set; }
    }
}
