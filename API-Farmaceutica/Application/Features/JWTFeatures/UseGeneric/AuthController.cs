using API_Farmaceutica.Application.Features.JWTFeatures.Login;
using API_Farmaceutica.Application.Features.JWTFeatures.RefreshToken;
using API_Farmaceutica.Application.Features.JWTFeatures.Register;
using API_Farmaceutica.Application.Features.JWTFeatures.UseGeneric.TokenGeneratorService;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
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
        private readonly IGenerateTokenService _generateTokenService;
        private readonly RefreshTokenHandler _refreshTokenHandler;

        public AuthController(RegisterUsuarioHandler registerUsuarioHandler, LoginUsuarioHandler loginUsuarioHandler, RefreshTokenHandler refreshTokenHandler, IGenerateTokenService generateTokenService)
        {
            _registerUsuarioHandler = registerUsuarioHandler;
            _loginUsuarioHandler = loginUsuarioHandler;
            _refreshTokenHandler = refreshTokenHandler;
            _generateTokenService = generateTokenService;
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
        public async Task<ActionResult<TokenResponse>> Login(GetUsuarioLoginRequest request)
        {
            try
            {
                var usuarioLogged = await _loginUsuarioHandler.HandlerAsync(request);
                if (usuarioLogged.Value == null)
                    return BadRequest(usuarioLogged.Errors);

                TokenResponse userToken = await _generateTokenService.GenerateTokenAsync(usuarioLogged.Value);
                return Ok(userToken);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult<TokenResponse>> RefreshToken(RefreshTokenRequest request)
        {
            var result = await _refreshTokenHandler.RefreshTokenAsync(request);
            if (result == null || result.AccessToken == null || result.RefreshToken == null)
                return Unauthorized("No se pudo validar el refresco de token.");
            return result;
        }  

        

    }
}
