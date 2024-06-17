using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using MediatR;

public record GetCenterByIdRequest(Guid Id):IRequest<GetCenterDto>;
