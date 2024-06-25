using FutureEducationalPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class Role:BaseModel
    {
        public string Name { get; set; }
        public virtual IEnumerable<UserRoles> Users { get; set;}
    }
}
