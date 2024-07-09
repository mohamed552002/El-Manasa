using FutureEducationalPlatform.Application.DTOS.ExamQuestionDtos;
using MediatR;

public record CreateExamQuestionRequest(CreateExamQuestionDto CreateExamQuestionDto):IRequest<string>;
