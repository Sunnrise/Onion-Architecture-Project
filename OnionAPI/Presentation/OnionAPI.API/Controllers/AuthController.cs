using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionAPI.Application.Features.Auth.Command.Login;
using OnionAPI.Application.Features.Auth.Command.RefreshToken;
using OnionAPI.Application.Features.Auth.Command.Register;
using OnionAPI.Application.Features.Auth.Command.Revoke;
using OnionAPI.Application.Features.Auth.Command.RevokeAll;

namespace OnionAPI.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommandRequest request)
        {
            await mediator.Send(request);
            return StatusCode(StatusCodes.Status201Created);
        }


        [HttpPost]
        public async Task<IActionResult> Auth(LoginCommandRequest request)
        {
            var response =await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost]
        public async Task<IActionResult> RefreshToken(RefreshTokenCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost]
        public async Task<IActionResult> Revoke(RevokeCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpPost]
        public async Task<IActionResult> RevokeAll()
        {
            var response = await mediator.Send(new RevokeAllCommandRequest());
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
