using API_Farmaceutica.Application.Features.JWTFeatures.UseGeneric;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Domain.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace API_Farmaceutica.Application.Features.JWTFeatures.UseGeneric.TokenGeneratorService
{
    public class GenerateTokenService : IGenerateTokenService
    {
        private readonly IConfiguration _configuration;
        private readonly IUsusarioRepository _usuarioRepository;

        public GenerateTokenService(IConfiguration configuration, IUsusarioRepository usuarioRepository)
        {
            _configuration = configuration;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<TokenResponse> GenerateTokenAsync(Usuarios usuario)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
            new Claim(ClaimTypes.Email, usuario.Email),
            new Claim(ClaimTypes.Role, usuario.Rol.ToString()),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(
                    int.Parse(_configuration["Jwt:ExpirationMinutes"] ?? "60")),
                signingCredentials: creds
            );
            TokenResponse response = new TokenResponse
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                RefreshToken = await GenAndSavedRefreshTokenAsync(usuario)
            };

            return response;
        }


        private async Task<string> GenAndSavedRefreshTokenAsync(Usuarios usuario)
        {
            string refreshToken = GenTokenRefresh();
            usuario.Refreshtoken = refreshToken;
            usuario.Refreshtokenexpirytime = DateTime.UtcNow.AddDays(7);
            await _usuarioRepository.UpdateUsuario(usuario);
            return refreshToken;
        }

        private string GenTokenRefresh()
        {
            byte[] randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }
}
