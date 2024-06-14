namespace FutureEducationalPlatform.Application.Common.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string message) : base(message) { }
    }
    public class NoDataFoundException : Exception
    {
        public NoDataFoundException(string message) : base(message) { }
    }
    public class ValidationErrorException : Exception
    {
        public string[] Errors { get; private set; }
        public ValidationErrorException(string[] errors) : base("Multiple errors in Validation occurred. See error details.")
        {
            Errors = errors;
        }
    }
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message) { }
    }
}
