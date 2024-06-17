using FutureEducationalPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.CenterEntites
{
    public class Center:BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<CenterCourseTime> Courses { get; set; }
    }
}
