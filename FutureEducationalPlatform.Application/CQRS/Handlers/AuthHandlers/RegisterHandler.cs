using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Common.HelperMethods;
using FutureEducationalPlatform.Application.Common.Validators.AuthValidators;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class RegisterHandler : IRequestHandler<RegisterRequest, string>
    {
        private readonly IUserService _userService;
        private readonly IOTPServices _otpService;
        private readonly IRoleService _roleService;
        public RegisterHandler(IUserService userService, IOTPServices otpService, IRoleService roleService)
        {
            _userService = userService;
            _otpService = otpService;
            _roleService = roleService;
        }

        public async Task<string> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            if (await _userService.GetByUserNameAsync(request.CreateUserDto.UserName) != null|| await _userService.GetByEmailAsync(request.CreateUserDto.Email) != null) throw new BadRequestException("Email or userName is already exist");
            var user = await _userService.Create(request.CreateUserDto);
            await _roleService.AddToRoleAsync(user, "Student");
            _otpService.SendOTP(user.Email,user.Id.ToString());
            return "Verification code has been sent to your email.";
        }
    }
}
