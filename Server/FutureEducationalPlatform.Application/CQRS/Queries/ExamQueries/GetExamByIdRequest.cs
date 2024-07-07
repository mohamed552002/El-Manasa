using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using MediatR;
public record GetExamByIdRequest(Guid Id):IRequest<GetExamDto>;