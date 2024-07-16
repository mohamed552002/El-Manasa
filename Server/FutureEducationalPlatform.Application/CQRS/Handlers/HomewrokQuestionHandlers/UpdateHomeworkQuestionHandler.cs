using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkQuestionCommands;
using FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomewrokQuestionHandlers
{
    public class UpdateHomeworkQuestionHandler : BaseHomeworkQuestionHandler, IRequestHandler<UpdateHomeworkQuestionRequest, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<HomeworkQuestion> _homeworkQuestionRepo;
        private readonly IBaseRepository<Homework> _homeworkRepo;
        private readonly IBaseRepository<Question> _QuestionRepo;
        public UpdateHomeworkQuestionHandler(IBaseService<HomeworkQuestion, GetHomeworkQuestionDto, CreateHomeworkQuestionDto, UpdateHomeworkQuestionDto> baseService, IUnitOfWork unitOfWork) : base(baseService)
        {
            _unitOfWork = unitOfWork;
            _homeworkQuestionRepo = _unitOfWork.GetRepository<HomeworkQuestion>();
            _homeworkRepo = _unitOfWork.GetRepository<Homework>();
            _QuestionRepo = _unitOfWork.GetRepository<Question>();
        }

        public async Task<string> Handle(UpdateHomeworkQuestionRequest request, CancellationToken cancellationToken)
        {
            if (await IsVaildExistence(request.UpdateHomeworkQuestionDto))
                throw new EntityNotFoundException("الواجب او السؤال غير موجود");
            if (await IsQuestionIdAndHomeworkIdUnique(request.UpdateHomeworkQuestionDto))
                throw new BadRequestException("هذا السؤال مربوط بهذا الواجب مسبقا");
            await _baseService.Update(request.Id, request.UpdateHomeworkQuestionDto);
            return "تم تعديل ربط السؤال بالواجب بنجاح";
        }
        private async Task<bool> IsQuestionIdAndHomeworkIdUnique(UpdateHomeworkQuestionDto updateHomeworkQuestionDto)
        {
            return !await _homeworkQuestionRepo.IsExist(hq => hq.QuestionId == updateHomeworkQuestionDto.QuestionId)
                && !await _homeworkQuestionRepo.IsExist(hq => hq.HomeworkId == updateHomeworkQuestionDto.HomeworkId);
        }
        private async Task<bool> IsVaildExistence(UpdateHomeworkQuestionDto updateHomeworkQuestionDto)
        {
            return !await _homeworkRepo.IsExist(c => c.Id == updateHomeworkQuestionDto.HomeworkId)
                || !await _QuestionRepo.IsExist(c => c.Id == updateHomeworkQuestionDto.QuestionId);
        }
    }
}
