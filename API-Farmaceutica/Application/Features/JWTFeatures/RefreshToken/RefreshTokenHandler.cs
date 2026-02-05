using API_Farmaceutica.Application.Features.JWTFeatures.UseGeneric;
using API_Farmaceutica.Application.Features.JWTFeatures.UseGeneric.TokenGeneratorService;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Domain.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace API_Farmaceutica.Application.Features.JWTFeatures.RefreshToken
{
    public class RefreshTokenHandler
    {
        private readonly IUsusarioRepository _usuarioRepository;
        private readonly IGenerateTokenService _generateTokenService;


        public RefreshTokenHandler(IUsusarioRepository usuarioRepository, IGenerateTokenService generateTokenService)
        {
            _usuarioRepository = usuarioRepository;
            _generateTokenService = generateTokenService;
        }

        public async Task<TokenResponse> RefreshTokenAsync(RefreshTokenRequest request)
        {
            Usuarios? user = await ValidateRefreshTokenAsync(request.UsuarioId, request.RefreshToken);
            if (user == null)
                return null;
            return await _generateTokenService.GenerateTokenAsync(user);
        }

        private async Task<Usuarios?> ValidateRefreshTokenAsync(Guid userId, string refreshToken)
        {
            Usuarios usuario = await _usuarioRepository.GetUsuarioByGuid(userId);
            if (usuario == null || usuario.Refreshtoken != refreshToken 
                || usuario.Refreshtokenexpirytime <= DateTime.UtcNow)
            {
                return null;
            }
            return usuario;
        }
    }
}
