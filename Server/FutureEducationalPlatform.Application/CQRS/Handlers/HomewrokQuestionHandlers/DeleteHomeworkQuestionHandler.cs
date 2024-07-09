

using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkQuestionCommands;
using FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomewrokQuestionHandlers
{
    public class DeleteHomeworkQuestionHandler : BaseHomeworkQuestionHandler, IRequestHandler<DeleteHomeworkQuestionRequest, string>
    {
        public DeleteHomeworkQuestionHandler(IBaseService<HomeworkQuestion, GetHomeworkQuestionDto, CreateHomeworkQuestionDto, UpdateHomeworkQuestionDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(DeleteHomeworkQuestionRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم الحذف بنجاح";
        }
    }
}
