using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterHandlers
{
    public class GetCentersHandler : BaseCenterHandler, IRequestHandler<GetCentersRequest, IEnumerable<GetCenterDto>>
    {
        public GetCentersHandler(IBaseService<Center, GetCenterDto, CreateCenterDto, UpdateCenterDto> baseService) : base(baseService) { }

        public async Task<IEnumerable<GetCenterDto>> Handle(GetCentersRequest request, CancellationToken cancellationToken) => 
            await _baseService.GetAllAsync();
    }
}
