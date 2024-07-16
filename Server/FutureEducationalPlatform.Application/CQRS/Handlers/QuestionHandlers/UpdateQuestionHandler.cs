using FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands;
using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.QuestionHandlers
{
    public class UpdateQuestionHandler : BaseQuestionHandler, IRequestHandler<UpdateQuestionRequest, string>
    {
        public UpdateQuestionHandler(IBaseService<Question, GetQuestionDto, CreateQuestionDto, UpdateQuestionDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(UpdateQuestionRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Update(request.Id, request.UpdateQuestionDto);
            return "تم تحديث السؤال بنجاح";
        }
    }
}
