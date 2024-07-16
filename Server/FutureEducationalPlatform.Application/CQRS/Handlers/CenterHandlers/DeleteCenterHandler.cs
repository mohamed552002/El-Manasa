using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterHandlers
{
    public class DeleteCenterHandler : BaseCenterHandler, IRequestHandler<DeleteCenterRequest, string>
    {
        public DeleteCenterHandler(IBaseService<Center, GetCenterDto, CreateCenterDto, UpdateCenterDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(DeleteCenterRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف السنتر بنجاح";
        }
    }
}
