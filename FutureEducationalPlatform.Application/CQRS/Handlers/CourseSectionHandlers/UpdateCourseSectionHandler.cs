using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseSectionHandlers
{
    public class UpdateCourseSectionHandler : BaseCourseSectionHandler, IRequestHandler<UpdateCourseSectionRequest, string>
    {
        public UpdateCourseSectionHandler(IBaseService<CourseSection, GetCourseSectionDto, CreateCourseSectionDto, UpdateCourseSectionDto> baseService) : base(baseService) { }

        public async Task<string> Handle(UpdateCourseSectionRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Update(request.Id,request.UpdateCourseSectionDto);
            return "تم تحديث بيانات هذا القسم بنجاح";
        }
    }
}
