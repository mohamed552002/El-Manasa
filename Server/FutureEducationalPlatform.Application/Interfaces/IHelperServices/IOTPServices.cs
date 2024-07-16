namespace FutureEducationalPlatform.Application.Interfaces.IHelperServices
{
    public interface IOTPServices
    {
        void SendOTP(string email, string entity);
        bool VerifyOTP(string entity, string OTP);
    }
}
