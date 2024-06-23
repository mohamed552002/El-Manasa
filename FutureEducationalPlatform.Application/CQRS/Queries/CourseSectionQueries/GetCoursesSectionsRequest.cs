using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using MediatR;

public record GetCoursesSectionsRequest():IRequest<IEnumerable<GetCourseSectionDto>>;
