using API_Farmaceutica.Application.Features.JWTFeatures.Register;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API_Farmaceutica.Application.Features.JWTFeatures.UseGeneric
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly GenerateToken _GenerateToken;
        private readonly Authenticate _Authenticate;

        public AuthController(GenerateToken generateToken, Authenticate authenticate)
        {
            _GenerateToken = generateToken;
            _Authenticate = authenticate;
        }


        [HttpPost("register")]
        public async Task<ActionResult<Usuarios>> RegisterEndpoint(GetUsuarioRegisterRequest request)
        {
            Usuarios? usuario = await _Authenticate.RegisterUsuarioAsync(request);

            if(usuario == null)
            {
                return BadRequest("Usuario ya existe.");
            }

            return Ok(usuario);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginEndpoint(GetUsuarioRegisterRequest request)
        {
            Usuarios? usuario = await _Authenticate.LoginUsuarioAsync(request);

            if(usuario == null)
            {
                return BadRequest("Credenciales inválidas. Usuario o contraseña incorrectos.");
            }

            string userToken = _GenerateToken.GenToken(usuario);

            return Ok(userToken);
        }

        

    }
}
