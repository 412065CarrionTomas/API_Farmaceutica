using Domain.Models;

namespace API_Farmaceutica.Application.Features.JWTFeatures.UseGeneric.TokenGeneratorService
{
    public interface IGenerateTokenService
    {
        Task<TokenResponse> GenerateTokenAsync(Usuarios usuario);
    }
}
