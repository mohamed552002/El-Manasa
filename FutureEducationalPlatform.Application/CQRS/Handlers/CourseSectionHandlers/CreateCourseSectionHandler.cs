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
    public class CreateCourseSectionHandler : BaseCourseSectionHandler, IRequestHandler<CreateCourseSectionRequest, string>
    {
        public CreateCourseSectionHandler(IBaseService<CourseSection, GetCourseSectionDto, CreateCourseSectionDto, UpdateCourseSectionDto> baseService) : base(baseService) { }
        public async Task<string> Handle(CreateCourseSectionRequest request, CancellationToken cancellationToken)
        {
            await _baseService.CreateAsync(request.CreateCourseSectionDto);
            return "تمت اضافه هذا القسم بنجاح";
        }
    }
}
