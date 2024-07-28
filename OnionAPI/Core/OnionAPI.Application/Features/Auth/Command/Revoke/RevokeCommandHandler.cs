using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using OnionAPI.Application.Bases;
using OnionAPI.Application.Features.Auth.Rules;
using OnionAPI.Application.Interfaces.AutoMapper;
using OnionAPI.Application.Interfaces.UnitOfWorks;
using OnionAPI.Domain.Entities;

namespace OnionAPI.Application.Features.Auth.Command.Revoke
{
    public class RevokeCommandHandler : BaseHandler, IRequestHandler<RevokeCommandRequest, Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;

        public RevokeCommandHandler(UserManager<User> userManager,AuthRules authRules,IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.userManager = userManager;
            this.authRules = authRules;
        }

        public async Task<Unit> Handle(RevokeCommandRequest request, CancellationToken cancellationToken)
        {
            User user = userManager.FindByEmailAsync(request.Email).Result;
            await authRules.EmailAddressShouldBeValid(user);
            user.refreshToken = null;
            await userManager.UpdateAsync(user);
            return Unit.Value;
        }
    }
}
