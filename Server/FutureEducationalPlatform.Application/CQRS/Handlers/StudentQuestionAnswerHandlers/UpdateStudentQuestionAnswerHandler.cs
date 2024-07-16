using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.DTOS.StudentQuestionAnswerDtos;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using FutureEducationalPlatform.Domain.Entities.StudentQuestionAnswerEntites;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.StudentQuestionAnswerHandlers
{
    public class UpdateStudentQuestionAnswerHandler : BaseStudentQuestionAnswerHandler, IRequestHandler<UpdateStudentQuestionAnswerRequest, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Student> _studentRepository;
        private readonly IBaseRepository<Question> _questionRepository;
        public UpdateStudentQuestionAnswerHandler(IBaseService<StudentQuestionAnswer, GetStudentQuestionAnswerDto, CreateStudentQuestionAnswerDto, UpdateStudentQuestionAnswerDto> baseService,IUnitOfWork unitOfWork) : base(baseService)
        {
            _unitOfWork = unitOfWork;
            _studentRepository = _unitOfWork.GetRepository<Student>();
            _questionRepository = _unitOfWork.GetRepository<Question>();
        }

        public async Task<string> Handle(UpdateStudentQuestionAnswerRequest request, CancellationToken cancellationToken)
        {
            if (!await _questionRepository.IsExist(q => q.Id == request.UpdateStudentQuestionAnswerDto.QuestionId) || !await _studentRepository.IsExist(s => s.Id == request.UpdateStudentQuestionAnswerDto.StudentId))
                throw new EntityNotFoundException("الطالب او السؤال غير موجود");
            await _baseService.Update(request.Id,request.UpdateStudentQuestionAnswerDto);
            return "تم تحديث البيانات بنجاح";
        }
    }
}
