﻿using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Queries.CourseQueries
{
    public class GetCoursesRequest : IRequest<IEnumerable<GetCourseDto>>{ }
}
