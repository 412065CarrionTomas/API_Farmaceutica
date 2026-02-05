namespace API_Farmaceutica.Application.Features.JWTFeatures.Register
{
    public record GetUsuarioRegisterRequest
    {
        public string Email { get; set; } = string.Empty;

        public string Passwordhash { get; set; } = string.Empty;

        public string Rol { get; set; } = "User";
    }
}
