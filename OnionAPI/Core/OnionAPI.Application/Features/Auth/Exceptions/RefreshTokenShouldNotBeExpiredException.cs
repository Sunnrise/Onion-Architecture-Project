using OnionAPI.Application.Bases;

namespace OnionAPI.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpiredException : BaseException
    {
        public RefreshTokenShouldNotBeExpiredException() : base("Please log in again") { }

    }
}
