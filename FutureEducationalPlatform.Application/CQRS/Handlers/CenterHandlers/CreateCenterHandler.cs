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
    public class CreateCenterHandler :BaseCenterHandler,IRequestHandler<CreateCenterRequest, string>
    {
        public CreateCenterHandler(IBaseService<Center, GetCenterDto, CreateCenterDto, UpdateCenterDto> baseService) : base(baseService){}
        public async Task<string> Handle(CreateCenterRequest request, CancellationToken cancellationToken)
        {
            await _baseService.CreateAsync(request.CreateCenterDto);
            return "تم اضافه السنتر بنجاح";
        }
    }
}
