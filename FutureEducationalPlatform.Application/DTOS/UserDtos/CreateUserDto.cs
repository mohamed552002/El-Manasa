using FutureEducationalPlatform.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.UserDtos
{
    public record CreateUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public GenderEnum Gender { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }=string.Empty;
    }
}
