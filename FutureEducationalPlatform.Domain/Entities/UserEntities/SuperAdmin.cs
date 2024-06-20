using FutureEducationalPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class SuperAdmin:BaseModel
    {
        public string ImgUrl { get; set; } 
        public User User { get; set; }
    }
}
