

namespace FutureEducationalPlatform.Application.Exceptions
{
    public class EntityNotFoundException: Exception
    {
        public EntityNotFoundException(string message):base(message) { }
    }
    public class NoDataFoundException : Exception
    {
        public NoDataFoundException(string message):base (message) { }
    }
    public class ValidationErrorException : Exception
    {
        public ValidationErrorException(string message) : base(message) { }
    }
}
