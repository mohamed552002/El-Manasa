using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using MediatR;
public record CreateCourseRequest(CreateCourseDto CreateCourseDto) : IRequest<string>;

