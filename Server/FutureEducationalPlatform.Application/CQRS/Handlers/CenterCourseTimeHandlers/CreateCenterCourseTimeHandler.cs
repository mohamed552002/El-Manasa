﻿using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterCourseTimeHandlers
{
    public class CreateCenterCourseTimeHandler : BaseCenterCourseTimeHandler, IRequestHandler<CreateCenterCourseTimeRequest, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Center> _centerRepository;
        private readonly IBaseRepository<CenterCourseTime> _centerCourseTimeRepository;
        private readonly IBaseRepository<Course> _courseRepository;
        public CreateCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, CreateCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService,IUnitOfWork unitOfWork) : base(baseService)
        {
            _unitOfWork = unitOfWork;
            _centerCourseTimeRepository= _unitOfWork.GetRepository<CenterCourseTime>();
            _centerRepository=_unitOfWork.GetRepository<Center>();
            _courseRepository=_unitOfWork.GetRepository<Course>();
        }

        public async Task<string> Handle(CreateCenterCourseTimeRequest request, CancellationToken cancellationToken)
        {
            if (!await _centerRepository.IsExist(c => c.Id == request.CreateCenterCourseTimeDto.CenterId) || !await _courseRepository.IsExist(c => c.Id == request.CreateCenterCourseTimeDto.CourseId))
                throw new EntityNotFoundException("الكورس او السنتر غير موجود");
            if (await _centerCourseTimeRepository.IsExist(ct => ct.CourseId == request.CreateCenterCourseTimeDto.CourseId && ct.CenterId == request.CreateCenterCourseTimeDto.CenterId))
                throw new BadRequestException("الميعاد موجود بالفعل");
            await _baseService.CreateAsync(request.CreateCenterCourseTimeDto);
            return "تمت اضافة الموعد بنجاح";
        }
    }
}
