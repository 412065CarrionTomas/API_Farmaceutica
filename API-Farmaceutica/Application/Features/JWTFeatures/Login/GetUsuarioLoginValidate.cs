using API_Farmaceutica.Application.Features.JWTFeatures.Register;
using API_Farmaceutica.Application.Shareds.ROP;
using System.Collections.Immutable;

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

            string[] rolesPermitidos = new[] { "Admin", "User" };
            if (!rolesPermitidos.Contains(request.Rol))
                errors.Add("Los unicos roles permitidos son 'Admin' o 'User'");

            return errors.Any()
                ? ResultExtension.Failure<GetUsuarioLoginRequest>(errors.ToImmutableArray())
                : request;
        }
    }
}
