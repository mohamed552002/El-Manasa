using FutureEducationalPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.AuthEntites
{
    public class RefreshToken : BaseModel
    {
        public string Token { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ExpiredOn { get; set; } = DateTime.UtcNow.AddDays(15);
        public bool IsExpired => DateTime.UtcNow >= ExpiredOn;
        public bool IsActive => !IsExpired;
    }
}
