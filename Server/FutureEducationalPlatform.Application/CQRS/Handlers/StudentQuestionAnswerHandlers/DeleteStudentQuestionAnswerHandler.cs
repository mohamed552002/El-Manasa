using FutureEducationalPlatform.Application.DTOS.StudentQuestionAnswerDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.StudentQuestionAnswerEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.StudentQuestionAnswerHandlers
{
    public class DeleteStudentQuestionAnswerHandler : BaseStudentQuestionAnswerHandler, IRequestHandler<DeleteStudentQuestionAnswerRequest, string>
    {
        public DeleteStudentQuestionAnswerHandler(IBaseService<StudentQuestionAnswer, GetStudentQuestionAnswerDto, CreateStudentQuestionAnswerDto, UpdateStudentQuestionAnswerDto> baseService) : base(baseService) { }

        public async Task<string> Handle(DeleteStudentQuestionAnswerRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف العنصر بنجاح";
        }
    }
}
