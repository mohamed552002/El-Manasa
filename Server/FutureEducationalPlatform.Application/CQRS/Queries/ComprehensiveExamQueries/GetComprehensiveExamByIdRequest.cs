using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using MediatR;

public record GetComprehensiveExamByIdRequest(Guid Id) : IRequest<GetComprehensiveExamDto>;


