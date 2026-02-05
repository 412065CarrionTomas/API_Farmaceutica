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
            if (request.Passwordhash == null)
                errors.Add("Debe ingresar contrasenia.");

            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailRegex.IsMatch(request.Email))
                errors.Add("El email debe ser válido.");


            return errors.Any()
                ? ResultExtension.Failure<GetUsuarioLoginRequest>(errors.ToImmutableArray())
                : request;
        }
    }
}
