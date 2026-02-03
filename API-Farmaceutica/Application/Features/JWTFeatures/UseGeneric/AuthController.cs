using API_Farmaceutica.Application.Features.JWTFeatures.Login;
using API_Farmaceutica.Application.Features.JWTFeatures.Register;
using API_Farmaceutica.Application.Features.JWTFeatures.TokenGenerator;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ExceptionServices;

namespace API_Farmaceutica.Application.Features.JWTFeatures.UseGeneric
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly RegisterUsuarioHandler _registerUsuarioHandler;
        private readonly LoginUsuarioHandler _loginUsuarioHandler;
        private readonly GenerateToken _generateToken;

        public AuthController(RegisterUsuarioHandler registerUsuarioHandler, GenerateToken generateToken, LoginUsuarioHandler loginUsuarioHandler)
        {
            _registerUsuarioHandler = registerUsuarioHandler;
            _generateToken = generateToken;
            _loginUsuarioHandler = loginUsuarioHandler;
        }

        [HttpPost("register")]
        public async Task<ActionResult<string>> Register(GetUsuarioRegisterRequest request)
        {
            try
            {
                var result = await _registerUsuarioHandler.HandlerAsync(request);
                if (result.Value == null)
                    return BadRequest(result.Errors);
                return Ok(result.Value);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(GetUsuarioLoginRequest request)
        {
            try
            {
                var usuarioLogged = await _loginUsuarioHandler.HandlerAsync(request);
                if (usuarioLogged.Value == null)
                    return BadRequest(usuarioLogged.Errors);

                string userToken = _generateToken.GenToken(usuarioLogged.Value);
                return Ok(userToken);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }

        

    }
}
