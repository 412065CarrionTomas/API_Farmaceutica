using API_Farmaceutica.Application.Shareds.ROP;
using System.Collections.Immutable;

namespace API_Farmaceutica.Application.Features.JWTFeatures.Register
{
    public static class GetUsuarioRegisterValidate
    {
        public static Result<GetUsuarioRegisterRequest> ValidateRequest(GetUsuarioRegisterRequest request)
        {
            List<string> errors = new List<string>();
            if(request == null)
                errors.Add("Debe ingresar valores al registro.");
            if(request.Contrasenia == null)
                errors.Add("Debe ingresar contrasenia.");
            if (request.Contrasenia.Length < 8)
                errors.Add("La contrasenia debe tener minimo 8 caracteres.");
            if (request.Rol == null)
                errors.Add("El campo rol no puede estar vacio.");

            string[] rolesPermitidos = new[] { "Admin", "User" };
            if (!rolesPermitidos.Contains(request.Rol))
                errors.Add("Los unicos roles permitidos son 'Admin' o 'User'");

            return errors.Any()
                ? ResultExtension.Failure<GetUsuarioRegisterRequest>(errors.ToImmutableArray())
                : request;
        }
    }
}
