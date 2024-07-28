using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Auth.Command.RefreshToken
{
    public class RefreshTokenCommandValidator : AbstractValidator<RefreshTokenCommandRequest>
    {
        public RefreshTokenCommandValidator()
        {
            RuleFor(x => x.AccessToken).NotEmpty().WithMessage("Access Token is required");
            RuleFor(x => x.RefreshToken).NotEmpty().WithMessage("Refresh Token is required");
        }
    }
}
