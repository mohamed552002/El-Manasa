using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.AuthDtos
{
    public class ChangePasswordDto
    {
        public string newPassword { get; set; }
        public string oldPassword { get; set; }
        [JsonIgnore]
        public string? refreshToken { get; set; }
    }
}
