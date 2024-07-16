namespace FutureEducationalPlatform.Application.Common.HelperModels
{
    public class JWT
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double DurationMinutes { get; set; }
    }
}
