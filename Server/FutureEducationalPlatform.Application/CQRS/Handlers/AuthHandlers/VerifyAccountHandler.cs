using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using MediatR;


namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class VerifyAccountHandler : IRequestHandler<VerifyAccountRequest, AuthModel>
    {
        private readonly IUserService _userService;
        private readonly IJwtService _jwtService;
        private readonly IOTPServices _otpServices;

        public VerifyAccountHandler(IUserService userService, IJwtService jwtService, IOTPServices otpServices)
        {
            _userService = userService;
            _jwtService = jwtService;
            _otpServices = otpServices;
        }

        public async Task<AuthModel> Handle(VerifyAccountRequest request, CancellationToken cancellationToken)
        {
            var user=await _userService.GetByEmailAsync(request.VerifyAccountDto.Email);
            if (user == null) throw new EntityNotFoundException("خطأ في البريد الالكتروني");
            _otpServices.VerifyOTP(user.Id.ToString(),request.VerifyAccountDto.VerificationCode);
            user.EmailConfirmed = true;
            return await _jwtService.GetAuthModel(user);
        }
    }
}
