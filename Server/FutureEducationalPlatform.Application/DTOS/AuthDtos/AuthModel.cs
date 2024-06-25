using FutureEducationalPlatform.Domain.Entities.AuthEntites;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json.Serialization;

namespace FutureEducationalPlatform.Application.DTOS.AuthDtos
{
    public record AuthModel
    {
        public AuthModel(User user, RefreshToken refreshToken ,IEnumerable<string> roles , JwtSecurityToken token)
        {
            Email = user.Email;
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
            Token = new JwtSecurityTokenHandler().WriteToken(token);
            ExpiresOn=token.ValidTo;
            Roles = roles;
            RefreshToken = refreshToken.Token;
            RefreshTokenExpiration = refreshToken.ExpiredOn;
        }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}
