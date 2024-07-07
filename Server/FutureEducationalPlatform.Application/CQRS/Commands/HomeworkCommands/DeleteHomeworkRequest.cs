﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands
{
    public record DeleteHomeworkRequest(Guid Id):IRequest<string>;
}
