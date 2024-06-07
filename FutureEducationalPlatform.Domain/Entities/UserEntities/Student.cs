using FutureEducationalPlatform.Domain.Common;
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
        public Guid Id { get; set; }
        public int GradeLevel { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public User User { get; set; }
    }
}
