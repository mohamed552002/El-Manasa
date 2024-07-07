using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using MediatR;

public record GetCourseSectionByIdRequest(Guid Id):IRequest<GetCourseSectionDto>;