using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using MediatR;

public record UpdateCenterCourseTimeRequest(Guid Id,UpdateCenterCourseTimeDto UpdateCenterCourseTimeDto):IRequest<string>;

