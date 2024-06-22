using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Queries.QuestionQueries
{
    public record GetQuestionByIdRequest(Guid Id):IRequest<GetQuestionDto>;

}
