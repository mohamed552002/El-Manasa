using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseSectionHandlers
{
    public class GetCourseSectionByIdHandler : BaseCourseSectionHandler, IRequestHandler<GetCourseSectionByIdRequest, GetCourseSectionDto>
    {
        public GetCourseSectionByIdHandler(IBaseService<CourseSection, GetCourseSectionDto, CreateCourseSectionDto, UpdateCourseSectionDto> baseService) : base(baseService) { }
        public async Task<GetCourseSectionDto> Handle(GetCourseSectionByIdRequest request, CancellationToken cancellationToken) =>
            await _baseService.GetByIdAsync(request.Id);
    }
}
