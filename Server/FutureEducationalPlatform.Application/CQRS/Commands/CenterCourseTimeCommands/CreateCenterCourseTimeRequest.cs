using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using MediatR;

public record CreateCenterCourseTimeRequest(CreateCenterCourseTimeDto CreateCenterCourseTimeDto) :IRequest<string>;
