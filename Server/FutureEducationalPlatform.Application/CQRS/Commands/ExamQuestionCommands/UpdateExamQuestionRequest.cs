using FutureEducationalPlatform.Application.DTOS.ExamQuestionDtos;
using MediatR;

public record UpdateExamQuestionRequest(Guid Id,UpdateExamQuestionDto UpdateExamQuestionDto):IRequest<string>;

