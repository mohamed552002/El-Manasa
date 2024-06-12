using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
