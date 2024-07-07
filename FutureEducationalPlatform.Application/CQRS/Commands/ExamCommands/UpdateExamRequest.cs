using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using MediatR;
public record UpdateExamRequest(Guid Id,UpdateExamDto UpdateExamDto):IRequest<string>;
