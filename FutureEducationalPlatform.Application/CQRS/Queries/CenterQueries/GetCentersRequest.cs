using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using MediatR;

public record GetCentersRequest():IRequest<IEnumerable<GetCenterDto>>;
