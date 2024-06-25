using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands
{
    public class ForgetPasswordRequest : IRequest
    {
        public string email { get; }

        public ForgetPasswordRequest(string email)
        {
            this.email = email;
        }
    }
}
