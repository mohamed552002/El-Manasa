using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;

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
