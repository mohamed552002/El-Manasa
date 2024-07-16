namespace FutureEducationalPlatform.Application.DTOS.AuthDtos
{
    public record ResetPasswordDto
    (
        string newPassword,
        string email,
        string OTP
    );
}
