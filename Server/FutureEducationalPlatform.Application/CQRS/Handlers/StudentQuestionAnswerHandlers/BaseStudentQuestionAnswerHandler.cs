using FutureEducationalPlatform.Application.DTOS.StudentQuestionAnswerDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.StudentQuestionAnswerEntites;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.StudentQuestionAnswerHandlers
{
    public class BaseStudentQuestionAnswerHandler
    {
        protected readonly IBaseService<StudentQuestionAnswer,GetStudentQuestionAnswerDto,CreateStudentQuestionAnswerDto,UpdateStudentQuestionAnswerDto> _baseService;

        public BaseStudentQuestionAnswerHandler(IBaseService<StudentQuestionAnswer, GetStudentQuestionAnswerDto, CreateStudentQuestionAnswerDto, UpdateStudentQuestionAnswerDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
