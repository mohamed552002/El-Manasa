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
    public class CreateHomeworkQuestionHandler : BaseHomeworkQuestionHandler, IRequestHandler<CreateHomewrokQuestionRequest, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<HomeworkQuestion> _homeworkQuestionRepo;
        private readonly IBaseRepository<Homework> _homeworkRepo;
        private readonly IBaseRepository<Question> _QuestionRepo;
        public CreateHomeworkQuestionHandler(IBaseService<HomeworkQuestion, GetHomeworkQuestionDto, CreateHomeworkQuestionDto, UpdateHomeworkQuestionDto> baseService, IUnitOfWork unitOfWork) : base(baseService)
        {
            _unitOfWork = unitOfWork;
            _homeworkQuestionRepo = _unitOfWork.GetRepository<HomeworkQuestion>();
            _homeworkRepo = _unitOfWork.GetRepository<Homework>();
            _QuestionRepo = _unitOfWork.GetRepository<Question>();
        }

        public async Task<string> Handle(CreateHomewrokQuestionRequest request, CancellationToken cancellationToken)
        {
            if(await IsVaildExistence(request.CreateHomeworkQuestionDto))
                throw new EntityNotFoundException("الواجب او السؤال غير موجود");
            if (await IsQuestionIdAndHomeworkIdUnique(request.CreateHomeworkQuestionDto))
                throw new BadRequestException( "هذا السؤال مربوط بهذا الواجب مسبقا");
            await _baseService.CreateAsync(request.CreateHomeworkQuestionDto);
            return "تمت اضافة السؤال الي الواجب بنجاح";
        }
        private async Task<bool> IsQuestionIdAndHomeworkIdUnique(CreateHomeworkQuestionDto createHomeworkQuestionDto)
        {
            return !await _homeworkQuestionRepo.IsExist(hq => hq.QuestionId == createHomeworkQuestionDto.QuestionId) 
                && !await _homeworkQuestionRepo.IsExist(hq => hq.HomeworkId == createHomeworkQuestionDto.HomeworkId);
        }
        private async Task<bool> IsVaildExistence(CreateHomeworkQuestionDto createHomeworkQuestionDto)
        {
            return !await _homeworkRepo.IsExist(c => c.Id == createHomeworkQuestionDto.HomeworkId)
                || !await _QuestionRepo.IsExist(c => c.Id == createHomeworkQuestionDto.QuestionId);
        }
    }
}
