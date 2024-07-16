using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.StudentQuestionAnswerDtos;
using FutureEducationalPlatform.Domain.Entities.StudentQuestionAnswerEntites;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class StudentQuestionAnswerProfile:Profile
    {
        public StudentQuestionAnswerProfile()
        {
            CreateMap<CreateStudentQuestionAnswerDto, StudentQuestionAnswer>();
            CreateMap<StudentQuestionAnswer, GetStudentQuestionAnswerDto>();
            CreateMap<UpdateStudentQuestionAnswerDto, StudentQuestionAnswer>();
        }
    }
}
