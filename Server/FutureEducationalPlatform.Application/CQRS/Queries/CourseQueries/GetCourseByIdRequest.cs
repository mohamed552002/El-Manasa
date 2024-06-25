using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using MediatR;

public record GetCourseByIdRequest(Guid Id) : IRequest<GetCourseDto>;


