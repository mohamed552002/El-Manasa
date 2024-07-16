using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterCourseTimeHandlers
{
    public class UpdateCenterCourseTimeHandler : BaseCenterCourseTimeHandler,IRequestHandler<UpdateCenterCourseTimeRequest, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Center> _centerRepository;
        private readonly IBaseRepository<Course> _courseRepository;
        private readonly IBaseRepository<CenterCourseTime> _centerCourseTimeRepository;
        public UpdateCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, CreateCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService,IUnitOfWork unitOfWork) : base(baseService)
        {
            _unitOfWork = unitOfWork;
            _centerRepository= _unitOfWork.GetRepository<Center>();
            _courseRepository= _unitOfWork.GetRepository<Course>();
            _centerCourseTimeRepository= _unitOfWork.GetRepository<CenterCourseTime>();
        }
        public async Task<string> Handle(UpdateCenterCourseTimeRequest request, CancellationToken cancellationToken)
        {
            if (!await _centerRepository.IsExist(c => c.Id == request.UpdateCenterCourseTimeDto.CenterId) || !await _courseRepository.IsExist(c => c.Id == request.UpdateCenterCourseTimeDto.CourseId))
                throw new EntityNotFoundException("الكورس او السنتر غير موجود");
            if (await _centerCourseTimeRepository.IsExist(ct => ct.CourseId == request.UpdateCenterCourseTimeDto.CourseId && ct.CenterId == request.UpdateCenterCourseTimeDto.CenterId&&ct.Id!=request.Id))
                throw new BadRequestException("حدث خطا ما");
            await _baseService.Update(request.Id, request.UpdateCenterCourseTimeDto);
            return "تم التحديث بنجاح";
        }
    }
}
