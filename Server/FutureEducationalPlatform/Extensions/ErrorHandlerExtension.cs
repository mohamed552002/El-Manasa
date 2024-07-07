﻿using FutureEducationalPlatform.Application.Common.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Text.Json;

namespace FutureEducationalPlatform.Extensions
{
    public static class ErrorHandlerExtension
    {
        public static void UseErrorHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            appError.Run(async context =>
            {
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature == null) return;

                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = contextFeature.Error switch
                {
                    BadRequestException => (int)HttpStatusCode.BadRequest,
                    EntityNotFoundException => (int)HttpStatusCode.NotFound,
                    NoDataFoundException => (int)HttpStatusCode.NotFound,
                    ValidationErrorException => (int)HttpStatusCode.BadRequest,
                    _ => (int)HttpStatusCode.InternalServerError
                };
                var errorResponse = new
                {
                    statusCode = context.Response.StatusCode,
                    message = contextFeature.Error.GetBaseException().Message,
                    Errors=contextFeature.Error switch
                    {
                        ValidationErrorException validationErrorException => validationErrorException.Errors,
                        _=>null
                    }
                };
                await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
            })
            );
        }

    }
}
