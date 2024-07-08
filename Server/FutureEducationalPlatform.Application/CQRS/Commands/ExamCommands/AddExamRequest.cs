using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using MediatR;
public record AddExamRequest(AddExamDto AddExamDto):IRequest<string>;
