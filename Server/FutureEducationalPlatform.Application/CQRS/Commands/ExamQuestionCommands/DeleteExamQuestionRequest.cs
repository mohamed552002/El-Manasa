using MediatR;
public record DeleteExamQuestionRequest(Guid Id):IRequest<string>;