using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using MediatR;

public record UpdateCourseSectionRequest(Guid Id,UpdateCourseSectionDto UpdateCourseSectionDto):IRequest<string>;
  
