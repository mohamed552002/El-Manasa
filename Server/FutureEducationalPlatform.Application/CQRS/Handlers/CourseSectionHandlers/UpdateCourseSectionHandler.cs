using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Course> _courseRepository;
        public UpdateCourseSectionHandler(IBaseService<CourseSection, GetCourseSectionDto, CreateCourseSectionDto, UpdateCourseSectionDto> baseService, IUnitOfWork unitOfWork) : base(baseService)
        {
            _unitOfWork = unitOfWork;
            _courseRepository=_unitOfWork.GetRepository<Course>();  
        }

        public async Task<string> Handle(UpdateCourseSectionRequest request, CancellationToken cancellationToken)
        {
            if (!await _courseRepository.IsExist(c => c.Id == request.UpdateCourseSectionDto.CourseId))
                throw new EntityNotFoundException("الكورس غير موجود");
            await _baseService.Update(request.Id,request.UpdateCourseSectionDto);
            return "تم تحديث بيانات هذا القسم بنجاح";
        }
    }
}
