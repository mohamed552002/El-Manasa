using FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands;
using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterCourseTimeHandlers
{
    public class CreateCenterCourseTimeHandler : BaseCenterCourseTimeHandler, IRequestHandler<CreateCenterCourseTimeRequest, string>
    {
        public CreateCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, AddCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(CreateCenterCourseTimeRequest request, CancellationToken cancellationToken)
        {
            await _baseService.CreateAsync(request.AddCenterCourseTimeDto);
            return "تمت اضافة الموعد بنجاح";
        }
    }
}
