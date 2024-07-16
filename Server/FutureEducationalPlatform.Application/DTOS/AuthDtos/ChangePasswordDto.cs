using System.Text.Json.Serialization;

namespace FutureEducationalPlatform.Application.DTOS.AuthDtos
{
    public record ChangePasswordDto
    {
        public string newPassword { get; set; }
        public string oldPassword { get; set; }
        [JsonIgnore]
        public string? refreshToken { get; set; }
    }
}
