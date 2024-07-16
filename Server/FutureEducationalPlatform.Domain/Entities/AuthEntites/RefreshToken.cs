namespace FutureEducationalPlatform.Domain.Entities.AuthEntites
{
    public class RefreshToken
    {
        public bool IsDeleted { get; set; }
        public string Token { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ExpiredOn { get; set; } = DateTime.UtcNow.AddDays(15);
        public bool IsExpired => DateTime.UtcNow >= ExpiredOn;
        public bool IsActive => !IsExpired;
    }
}
