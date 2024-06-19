using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterCourseTimeHandlers
{
    public class UpdateCenterCourseTimeHandler : BaseCenterCourseTimeHandler,IRequestHandler<UpdateCenterCourseTimeRequest, string>
    {
        public UpdateCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, AddCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService) : base(baseService) { }
        public async Task<string> Handle(UpdateCenterCourseTimeRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Update(request.Id, request.UpdateCenterCourseTimeDto);
            return "تم التحديث بنجاح";
        }
    }
}
