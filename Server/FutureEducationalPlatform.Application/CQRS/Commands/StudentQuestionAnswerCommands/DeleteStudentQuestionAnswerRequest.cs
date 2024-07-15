using MediatR;
public record DeleteStudentQuestionAnswerRequest(Guid Id):IRequest<string>;