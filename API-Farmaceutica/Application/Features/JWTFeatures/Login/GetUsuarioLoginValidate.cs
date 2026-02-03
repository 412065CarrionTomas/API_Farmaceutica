using API_Farmaceutica.Application.Features.JWTFeatures.Register;
using API_Farmaceutica.Application.Shareds.ROP;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace API_Farmaceutica.Application.Features.JWTFeatures.Login
{
    public static class GetUsuarioLoginValidate
    {
        public static Result<GetUsuarioLoginRequest> ValidateRequest(GetUsuarioLoginRequest request)
        {
            List<string> errors = new List<string>();
            if (request == null)
                errors.Add("Debe ingresar valores al login.");
            if (request.Contrasenia == null)
                errors.Add("Debe ingresar contrasenia.");
            if (request.Rol == null)
                errors.Add("El campo rol no puede estar vacio.");

            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(request.Email))
                errors.Add("El email debe ser válido.");

            string[] rolesPermitidos = new[] { "Admin", "User" };
            if (!rolesPermitidos.Contains(request.Rol))
                errors.Add("Los unicos roles permitidos son 'Admin' o 'User'");

            return errors.Any()
                ? ResultExtension.Failure<GetUsuarioLoginRequest>(errors.ToImmutableArray())
                : request;
        }
    }
}
