using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using MediatR;
public record CreateCenterRequest(CreateCenterDto CreateCenterDto):IRequest<string>;
