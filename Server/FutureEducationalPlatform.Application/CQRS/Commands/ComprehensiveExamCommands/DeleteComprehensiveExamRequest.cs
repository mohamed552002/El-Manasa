using MediatR;
public record DeleteComprehensiveExamRequest(Guid Id):IRequest<string>;

