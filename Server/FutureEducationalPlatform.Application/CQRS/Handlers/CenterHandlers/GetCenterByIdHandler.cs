using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterHandlers
{
    public class GetCenterByIdHandler : BaseCenterHandler, IRequestHandler<GetCenterByIdRequest, GetCenterDto>
    {
        public GetCenterByIdHandler(IBaseService<Center, GetCenterDto, CreateCenterDto, UpdateCenterDto> baseService) : base(baseService) { }
        public async Task<GetCenterDto> Handle(GetCenterByIdRequest request, CancellationToken cancellationToken) =>
            await _baseService.GetByIdAsync(request.Id);
    }
}
