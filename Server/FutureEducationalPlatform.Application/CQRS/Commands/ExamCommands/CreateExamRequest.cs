using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using MediatR;
public record CreateExamRequest(CreateExamDto CreateExamDto):IRequest<string>;
