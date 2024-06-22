using MediatR;

public record DeleteCourseSectionRequest(Guid Id):IRequest<string>;
