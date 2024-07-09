using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.DTOS.ExamQuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamQuestionHandlers
{
    public class UpdateExamQuestionHandler : BaseExamQuestionHandler, IRequestHandler<UpdateExamQuestionRequest, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Exam> _examRepository;
        private readonly IBaseRepository<Question> _questionRepository;
        private readonly IBaseRepository<ExamQuestion> _examQuestionRepository;
        public UpdateExamQuestionHandler(IBaseService<ExamQuestion, GetExamQuestionDto, CreateExamQuestionDto, UpdateExamQuestionDto> baseService,IUnitOfWork unitOfWork) : base(baseService)
        {
            _unitOfWork = unitOfWork;
            _examRepository = _unitOfWork.GetRepository<Exam>();
            _questionRepository = _unitOfWork.GetRepository<Question>();
            _examQuestionRepository = _unitOfWork.GetRepository<ExamQuestion>();
        }

        public async Task<string> Handle(UpdateExamQuestionRequest request, CancellationToken cancellationToken)
        {
            if (!await _examRepository.IsExist(e => e.Id == request.UpdateExamQuestionDto.ExamId) || !await _questionRepository.IsExist(q => q.Id == request.UpdateExamQuestionDto.QuestionId))
                throw new EntityNotFoundException("الاختبار او السؤال غير موجود");
            if (await _examQuestionRepository.IsExist(eq => eq.ExamId == request.UpdateExamQuestionDto.ExamId && eq.QuestionId == request.UpdateExamQuestionDto.QuestionId && eq.Id != request.Id))
                throw new BadRequestException("السؤال موجود بالاختبار بالفعل");
            await _baseService.Update(request.Id, request.UpdateExamQuestionDto);
            return "تم تحديث بيانات العنصر بنجاح";
        }
    }
}
