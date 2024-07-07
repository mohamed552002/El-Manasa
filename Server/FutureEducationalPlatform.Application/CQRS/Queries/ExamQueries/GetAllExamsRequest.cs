using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using MediatR;
public record GetAllExamsRequest:IRequest<IEnumerable<GetExamDto>>;

