using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands;
using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomeworkHandlers
{
    public class DeleteHomeworkHandler : BaseHomeworkHandler, IRequestHandler<DeleteHomeworkRequest, string>
    {
        public DeleteHomeworkHandler(IBaseService<Homework, GetHomeworkDto, CreateHomeworkDto, UpdateHomeworkDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(DeleteHomeworkRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف الواجب بنجاح";
        }
    }
}
