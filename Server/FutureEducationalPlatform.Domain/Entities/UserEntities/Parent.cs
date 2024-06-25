using FutureEducationalPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class Parent:BaseModel
    {
        public string PhoneNumber { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
