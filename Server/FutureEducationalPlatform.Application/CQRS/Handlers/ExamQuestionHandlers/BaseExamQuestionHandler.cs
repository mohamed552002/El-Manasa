
using FutureEducationalPlatform.Application.DTOS.ExamQuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamQuestionHandlers
{
    public class BaseExamQuestionHandler
    {
        protected readonly IBaseService<ExamQuestion,GetExamQuestionDto,CreateExamQuestionDto,UpdateExamQuestionDto> _baseService;

        public BaseExamQuestionHandler(IBaseService<ExamQuestion, GetExamQuestionDto, CreateExamQuestionDto, UpdateExamQuestionDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
