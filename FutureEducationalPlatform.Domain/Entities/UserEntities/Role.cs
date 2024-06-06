using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<UserRoles> Users { get; set;}
    }
}
