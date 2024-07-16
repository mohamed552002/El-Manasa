using FutureEducationalPlatform.Domain.Entities.UserEntities;

namespace FutureEducationalPlatform.Application.Interfaces.IServices
{
    public interface IPasswordService
    {
        string HashPassword(string password);
        bool VerifyPassword(string password, string hashedPassword);
        void ChangePassword(User user, string oldPassword, string newPassword);
    }
}
