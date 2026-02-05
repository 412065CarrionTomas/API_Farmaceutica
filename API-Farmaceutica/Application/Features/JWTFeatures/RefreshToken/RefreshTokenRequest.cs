namespace API_Farmaceutica.Application.Features.JWTFeatures.RefreshToken
{
    public record RefreshTokenRequest
    {
        public Guid UsuarioId { get; set; }
        public required string RefreshToken { get; set; }
    }
}
