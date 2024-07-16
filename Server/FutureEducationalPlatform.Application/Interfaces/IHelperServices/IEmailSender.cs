namespace FutureEducationalPlatform.Application.Interfaces.IHelperServices
{
    public interface IEmailSender
    {
        void SendEmail(string email, string subject, string htmlMessage);
    }
}
