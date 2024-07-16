using MediatR;
public record DeleteCourseRequest(Guid Id):IRequest<string>;
 
   