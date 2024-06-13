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
        public string Password { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; } = string.Empty;
    }
}
