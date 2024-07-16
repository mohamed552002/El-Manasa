using FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomewrokQuestionHandlers
{
    public class BaseHomeworkQuestionHandler
    {
        protected readonly IBaseService<HomeworkQuestion, GetHomeworkQuestionDto, CreateHomeworkQuestionDto, UpdateHomeworkQuestionDto> _baseService;

        public BaseHomeworkQuestionHandler(IBaseService<HomeworkQuestion, GetHomeworkQuestionDto, CreateHomeworkQuestionDto, UpdateHomeworkQuestionDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
