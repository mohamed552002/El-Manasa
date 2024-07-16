using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseSectionHandlers
{
    public class GetCoursesSectionsHandler : BaseCourseSectionHandler, IRequestHandler<GetCoursesSectionsRequest, IEnumerable<GetCourseSectionDto>>
    {
        public GetCoursesSectionsHandler(IBaseService<CourseSection, GetCourseSectionDto, CreateCourseSectionDto, UpdateCourseSectionDto> baseService) : base(baseService) { }
        public async Task<IEnumerable<GetCourseSectionDto>> Handle(GetCoursesSectionsRequest request, CancellationToken cancellationToken) =>
            await _baseService.GetAllAsync();
    }
}
