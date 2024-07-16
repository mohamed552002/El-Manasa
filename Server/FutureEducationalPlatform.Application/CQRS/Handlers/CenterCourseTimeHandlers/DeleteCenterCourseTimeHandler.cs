using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterCourseTimeHandlers
{
    public class DeleteCenterCourseTimeHandler :BaseCenterCourseTimeHandler , IRequestHandler<DeleteCenterCourseTimeRequest, string>
    {
        public DeleteCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, CreateCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService) : base(baseService) { }
        public async Task<string> Handle(DeleteCenterCourseTimeRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف الميعاد بنجاح";
        }
    }
}
