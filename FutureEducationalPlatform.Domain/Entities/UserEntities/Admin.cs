using FutureEducationalPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.UserEntities
{
    public class Admin:BaseModel
    {
        public string ImageUrl { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }= DateTime.Now;
        public virtual User User { get; set; }
    }
}
