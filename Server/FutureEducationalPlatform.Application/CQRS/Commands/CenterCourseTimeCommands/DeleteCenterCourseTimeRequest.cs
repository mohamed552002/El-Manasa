using MediatR;

public record DeleteCenterCourseTimeRequest(Guid Id) : IRequest<string>;
