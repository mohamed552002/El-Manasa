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
        private readonly IIdentityService _identityService;
        private readonly IPasswordService _passwordService;

        public ResetPasswordHandler(IOTPServices otpServices, IIdentityService identityService, IPasswordService passwordService)
        {
            _otpServices = otpServices;
            _identityService = identityService;
            _passwordService = passwordService;
        }

        public async Task<string> Handle(ResetPasswordRequest request, CancellationToken cancellationToken)
        {
            _otpServices.VerifyOTP(request.ResetPasswordDto.email,request.ResetPasswordDto.OTP);
            var user =await _identityService.GetByEmailAsync(request.ResetPasswordDto.email);
            if (user == null)
                throw new EntityNotFoundException("Wrong Email");
            user.PasswordHash = _passwordService.HashPassword(request.ResetPasswordDto.newPassword);
            await _identityService.UpdateUser(user);
            return "تم تغيير كلمة السر بنجاح";
        }
    }
}
