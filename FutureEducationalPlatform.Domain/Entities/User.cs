using FutureEducationalPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities
{
    public class User:BaseModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime LastUpdatedAt { get; set;}
        public GenderEnum Gender { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? SecurityStamp { get; set; }
        public int AccessFailedCount { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool TwoFactorEnabled { get; set; }
    }
    public enum GenderEnum
    {
        Male,
        Female
    }
}
