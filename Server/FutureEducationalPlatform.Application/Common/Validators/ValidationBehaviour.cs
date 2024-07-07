using FluentValidation;
using FutureEducationalPlatform.Application.Common.Exceptions;
using MediatR;

namespace UnderAdmission.Application.Features_Imp.Common.Behaviors
{
    public sealed class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest: IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (!_validators.Any()) return await next();

            var validationContext = new ValidationContext<TRequest>(request);
            var validationErrors = new List<string>();

            foreach (var validator in _validators)
            {
                var validationResult = await validator.ValidateAsync(validationContext, cancellationToken);

                if (!validationResult.IsValid)
                {
                    validationErrors.AddRange(validationResult.Errors.Select(error => error.ErrorMessage));
                }
            }

            if (validationErrors.Any())
            {
                throw new ValidationErrorException(validationErrors.ToArray());
            }

            return await next();
        }
    }

}
