using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseSectionHandlers
{
    public class CreateCourseSectionHandler : BaseCourseSectionHandler, IRequestHandler<CreateCourseSectionRequest, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Course> _courseRepository;
        public CreateCourseSectionHandler(IBaseService<CourseSection, GetCourseSectionDto, CreateCourseSectionDto, UpdateCourseSectionDto> baseService, IUnitOfWork unitOfWork) : base(baseService)
        {
            _unitOfWork = unitOfWork;
            _courseRepository=_unitOfWork.GetRepository<Course>();
        }
        public async Task<string> Handle(CreateCourseSectionRequest request, CancellationToken cancellationToken)
        {
            if (!await _courseRepository.IsExist(c => c.Id == request.CreateCourseSectionDto.CourseId))
                throw new EntityNotFoundException("الكورس غير موجود");
            await _baseService.CreateAsync(request.CreateCourseSectionDto);
            return "تمت اضافه هذا القسم بنجاح";
        }
    }
}
