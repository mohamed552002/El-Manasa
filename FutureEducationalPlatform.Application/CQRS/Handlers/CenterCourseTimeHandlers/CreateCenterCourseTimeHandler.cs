using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands;
using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterCourseTimeHandlers
{
    public class CreateCenterCourseTimeHandler : BaseCenterCourseTimeHandler, IRequestHandler<CreateCenterCourseTimeRequest, string>
    {
        public CreateCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, AddCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService,IUnitOfWork unitOfWork) : base(baseService, unitOfWork)
        {
        }

        public async Task<string> Handle(CreateCenterCourseTimeRequest request, CancellationToken cancellationToken)
        {
            var CenterCourseTimeRepo = _unitOfWork.GetRepository<CenterCourseTime>();
            if (await CenterCourseTimeRepo.IsExist(ct => ct.CourseId == request.AddCenterCourseTimeDto.CourseId && ct.CenterId == request.AddCenterCourseTimeDto.CenterId))
                throw new EntityNotFoundException("الكورس او السنتر غير موجود");
            await _baseService.CreateAsync(request.AddCenterCourseTimeDto);
            return "تمت اضافة الموعد بنجاح";
        }
    }
}
