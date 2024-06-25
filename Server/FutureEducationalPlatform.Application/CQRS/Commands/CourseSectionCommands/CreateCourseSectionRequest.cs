using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using MediatR;

public record CreateCourseSectionRequest(CreateCourseSectionDto CreateCourseSectionDto):IRequest<string>;

