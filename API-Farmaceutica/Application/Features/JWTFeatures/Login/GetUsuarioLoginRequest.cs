namespace API_Farmaceutica.Application.Features.JWTFeatures.Login
{
    public record GetUsuarioLoginRequest
    {
        public string Email { get; set; } = string.Empty;

        public string Passwordhash { get; set; } = string.Empty;

    }
}
