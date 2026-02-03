namespace API_Farmaceutica.Application.Features.JWTFeatures.Register
{
    public class GetUsuarioRegisterRequest
    {
        public string Email { get; set; } = string.Empty;

        public string Contrasenia { get; set; } = string.Empty;

        public string Rol { get; set; } = "User";
    }
}
