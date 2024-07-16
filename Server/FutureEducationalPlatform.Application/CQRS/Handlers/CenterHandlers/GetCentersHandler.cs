using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterHandlers
{
    public class GetCentersHandler : BaseCenterHandler, IRequestHandler<GetCentersRequest, IEnumerable<GetCenterDto>>
    {
        public GetCentersHandler(IBaseService<Center, GetCenterDto, CreateCenterDto, UpdateCenterDto> baseService) : base(baseService) { }

        public async Task<IEnumerable<GetCenterDto>> Handle(GetCentersRequest request, CancellationToken cancellationToken) => 
            await _baseService.GetAllAsync();
    }
}
