using FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands;
using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterHandlers
{
    public class UpdateCenterHandler : BaseCenterHandler, IRequestHandler<UpdateCenterRequest, string>
    {
        public UpdateCenterHandler(IBaseService<Center, GetCenterDto, CreateCenterDto, UpdateCenterDto> baseService) : base(baseService) { }


        public async Task<string> Handle(UpdateCenterRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Update(request.Id, request.UpdateCenterDto);
            return "تم تحديث بيانات السنتر بنجاح";
        }
    }
}
