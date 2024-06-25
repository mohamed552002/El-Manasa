using MediatR;
public record DeleteCenterRequest(Guid Id):IRequest<string>;

