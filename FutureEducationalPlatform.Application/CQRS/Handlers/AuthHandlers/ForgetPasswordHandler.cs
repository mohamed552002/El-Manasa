using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class ForgetPasswordHandler : IRequestHandler<ForgetPasswordRequest>
    {
        private readonly IOTPServices _otpServices;
        private readonly IUnitOfWork _unitOfWork;

        public ForgetPasswordHandler(IOTPServices otpServices, IUnitOfWork unitOfWork)
        {
            _otpServices = otpServices;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(ForgetPasswordRequest request, CancellationToken cancellationToken)
        {
            if (!await _unitOfWork.UserRepository.IsExist(u => u.Email == request.email))
                throw new EntityNotFoundException("Wrong Email");
            _otpServices.SendOTP(request.email,request.email);
        }
    }
}
