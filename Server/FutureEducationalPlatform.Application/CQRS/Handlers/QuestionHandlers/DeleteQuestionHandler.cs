using FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands;
using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.QuestionHandlers
{
    public class DeleteQuestionHandler : BaseQuestionHandler, IRequestHandler<DeleteQuestionRequest, string>
    {
        public DeleteQuestionHandler(IBaseService<Question, GetQuestionDto, CreateQuestionDto, UpdateQuestionDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(DeleteQuestionRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف السؤال بنجاح";
        }
    }
}
