using FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands;
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
    public class DeleteCenterCourseTimeHandler :BaseCenterCourseTimeHandler , IRequestHandler<DeleteCenterCourseTimeRequest, string>
    {
        public DeleteCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, AddCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(DeleteCenterCourseTimeRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.id);
            return "تم حذف الميعاد بنجاح";
        }
    }
}
