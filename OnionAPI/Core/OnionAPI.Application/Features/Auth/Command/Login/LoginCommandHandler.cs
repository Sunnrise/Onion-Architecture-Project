using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using OnionAPI.Application.Bases;
using OnionAPI.Application.Features.Auth.Rules;
using OnionAPI.Application.Interfaces.AutoMapper;
using OnionAPI.Application.Interfaces.Tokens;
using OnionAPI.Application.Interfaces.UnitOfWorks;
using OnionAPI.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;

namespace OnionAPI.Application.Features.Auth.Command.Login
{
    public class LoginCommandHandler : BaseHandler, IRequestHandler<LoginCommandRequest, LoginCommandResponse>
    {
        private readonly UserManager<User> userManager;
        private readonly IConfiguration configuration;
        private readonly ITokenService tokenService;
        private readonly RoleManager<Role> roleManager;
        private readonly AuthRules authRules;

        public LoginCommandHandler(UserManager<User> userManager,IConfiguration configuration,ITokenService tokenService,RoleManager<Role> roleManager,AuthRules authRules,IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.tokenService = tokenService;
            this.roleManager = roleManager;
            this.authRules = authRules;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
             User user = await userManager.FindByEmailAsync(request.Email);
            bool checkPassword = await userManager.CheckPasswordAsync(user, request.Password);

            await authRules.EmailAddressShouldBeValid(user, checkPassword);

            IList<string> roles = await userManager.GetRolesAsync(user);

            JwtSecurityToken token = await tokenService.CreateToken(user, roles);

            string refreshToken = tokenService.GenerateRefreshToken();

            _=int.TryParse(configuration["JWT: RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

            user.refreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

            await userManager.UpdateAsync(user);
            await userManager.UpdateSecurityStampAsync(user);

            string _token= new JwtSecurityTokenHandler().WriteToken(token);


            await userManager.SetAuthenticationTokenAsync(user, "Default", "AccessToken", _token);

            return new()
            {
                Token = _token,
                RefreshToken = refreshToken,
                Expiration = token.ValidTo
            };

            


        }
    }
}
