using OnionAPI.Application.Bases;

namespace OnionAPI.Application.Features.Auth.Exceptions
{
    public class EmailAddressShouldBeValidException : BaseException
    {
        public EmailAddressShouldBeValidException() : base("There is no match") { }
    }
}
