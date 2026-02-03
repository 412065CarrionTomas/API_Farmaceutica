namespace API_Farmaceutica.Application.Features.JWTFeatures.Login
{
    public class GetUsuarioLoginRequest
    {
        public string Email { get; set; } = string.Empty;

        public string Contrasenia { get; set; } = string.Empty;

        public string Rol { get; set; } = "User";
    }
}
