using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands
{
    public record CreateQuestionRequest(CreateQuestionDto CreateQuestionDto) : IRequest<string>;

}
