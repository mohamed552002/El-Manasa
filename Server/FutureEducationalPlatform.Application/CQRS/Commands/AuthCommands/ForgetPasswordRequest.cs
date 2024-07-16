using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands
{
    public class ForgetPasswordRequest : IRequest<string>
    {
        public string email { get; }

        public ForgetPasswordRequest(string email)
        {
            this.email = email;
        }
    }
}
