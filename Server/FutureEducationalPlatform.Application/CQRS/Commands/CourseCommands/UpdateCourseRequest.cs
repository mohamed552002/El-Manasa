using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;
public record UpdateCourseRequest(Guid Id,UpdateCourseDto UpdateCourseDto):IRequest<Course>;
