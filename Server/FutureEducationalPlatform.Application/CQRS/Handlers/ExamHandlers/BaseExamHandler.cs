using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamHandlers
{
    public class BaseExamHandler
    {
        protected readonly IBaseService<Exam,GetExamDto,AddExamDto,UpdateExamDto> _baseService;
        public BaseExamHandler(IBaseService<Exam, GetExamDto, AddExamDto, UpdateExamDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
