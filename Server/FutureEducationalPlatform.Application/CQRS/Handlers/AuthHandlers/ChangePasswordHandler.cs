using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class ChangePasswordHandler : IRequestHandler<ChangePasswordRequest, string>
    {
        private readonly IPasswordService _passwordService;
        private readonly IUserService _userService;

        public ChangePasswordHandler(IPasswordService passwordService, IUserService userService)
        {
            _passwordService = passwordService;
            _userService = userService;
        }

        public async Task<string> Handle(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            var user =  await _userService.GetUserByRefreshTokenAsync(request.ChangePasswordDto.refreshToken);
            if (user == null || request.ChangePasswordDto.refreshToken == "")
                throw new EntityNotFoundException("المستخدم غير موجود");
            _passwordService.ChangePassword(user,request.ChangePasswordDto.oldPassword, request.ChangePasswordDto.newPassword);
            await _userService.Update(user);
            return request.ChangePasswordDto.newPassword;
        }
    }
}
