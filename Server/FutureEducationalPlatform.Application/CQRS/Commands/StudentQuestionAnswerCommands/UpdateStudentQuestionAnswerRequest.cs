﻿using FutureEducationalPlatform.Application.DTOS.StudentQuestionAnswerDtos;
using MediatR;
public record UpdateStudentQuestionAnswerRequest(Guid Id,UpdateStudentQuestionAnswerDto UpdateStudentQuestionAnswerDto):IRequest<string>;
