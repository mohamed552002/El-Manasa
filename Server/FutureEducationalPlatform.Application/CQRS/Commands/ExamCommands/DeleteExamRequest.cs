using MediatR;
public record DeleteExamRequest(Guid Id):IRequest<string>;

