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
    public class CreateStudentQuestionAnswerHandler : BaseStudentQuestionAnswerHandler, IRequestHandler<CreateStudentQuestionAnswerRequest, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<Student> _studentRepository;
        private readonly IBaseRepository<Question> _questionRepository;
        public CreateStudentQuestionAnswerHandler(IBaseService<StudentQuestionAnswer, GetStudentQuestionAnswerDto, CreateStudentQuestionAnswerDto, UpdateStudentQuestionAnswerDto> baseService,IUnitOfWork unitOfWork) : base(baseService)
        {
            _unitOfWork = unitOfWork;
            _studentRepository = _unitOfWork.GetRepository<Student>();
            _questionRepository = _unitOfWork.GetRepository<Question>();
        }

        public async Task<string> Handle(CreateStudentQuestionAnswerRequest request, CancellationToken cancellationToken)
        {
            if (!await _questionRepository.IsExist(q => q.Id == request.CreateStudentQuestionAnswerDto.QuestionId) || !await _studentRepository.IsExist(s => s.Id == request.CreateStudentQuestionAnswerDto.StudentId))
                throw new EntityNotFoundException("الطالب او السؤال غير موجود");
            await _baseService.CreateAsync(request.CreateStudentQuestionAnswerDto);
            return "تم اضافه الاجابه بنجاح";
        }
    }
}
