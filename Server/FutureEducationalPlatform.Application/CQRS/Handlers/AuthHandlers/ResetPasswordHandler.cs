using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class ResetPasswordHandler : IRequestHandler<ResetPasswordRequest,string>
    {
        private readonly IOTPServices _otpServices;
        private readonly IUserService _userService;
        private readonly IPasswordService _passwordService;

        public ResetPasswordHandler(IOTPServices otpServices,IUserService userService, IPasswordService passwordService)
        {
            _otpServices = otpServices;
            _userService = userService;
            _passwordService = passwordService;
        }

        public async Task<string> Handle(ResetPasswordRequest request, CancellationToken cancellationToken)
        {
            _otpServices.VerifyOTP(request.ResetPasswordDto.email,request.ResetPasswordDto.OTP);
            var user =await _userService.GetByEmailAsync(request.ResetPasswordDto.email);
            if (user == null)
                throw new EntityNotFoundException("خطأ في البريد الالكتروني");
            user.PasswordHash = _passwordService.HashPassword(request.ResetPasswordDto.newPassword);
            await _userService.Update(user);
            return "تم تغيير كلمة السر بنجاح";
        }
    }
}
