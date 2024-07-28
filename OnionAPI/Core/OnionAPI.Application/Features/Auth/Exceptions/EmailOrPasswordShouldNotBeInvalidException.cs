using OnionAPI.Application.Bases;

namespace OnionAPI.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidException: BaseException
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Username or password not invalid") { }    
    }
}
