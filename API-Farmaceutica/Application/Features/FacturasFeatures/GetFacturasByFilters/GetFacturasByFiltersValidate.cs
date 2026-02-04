using API_Farmaceutica.Application.Shareds.ROP;
using Domain.Models;
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters
{
    public static class GetFacturasByFiltersValidate
    {

        public static Result<GetFacturasByFiltersRequest> ValidateRequest(GetFacturasByFiltersRequest request)
        {
            List<string>? errors = new List<string>();
            if (request.FacturaID <= 0)
                errors.Add($"No puede ingresar un {nameof(GetFacturasByFiltersRequest.FacturaID)} " +
                    $"menor/igual a 0.");
            if (request.FechaInicio > request.FechaFin)
                errors.Add($"La {nameof(GetFacturasByFiltersRequest.FechaInicio)} no " +
                    $"puede ser mayor a la fecha de fin");
            if (request.EmpleadoID <= 0)
                errors.Add($"No puede ingresar un {nameof(GetFacturasByFiltersRequest.EmpleadoID)} " +
                    $"menor/igual a 0.");
            if (request.SucursalID <= 0)
                errors.Add($"No puede ingresar un {nameof(GetFacturasByFiltersRequest.SucursalID)} " +
                    $"menor/igual a 0.");
            if (request.MetodoPagoID <= 0)
                errors.Add($"No puede ingresar un {nameof(GetFacturasByFiltersRequest.MetodoPagoID)} " +
                    $"menor/igual a 0.");

            return errors.Any()
                ? ResultExtension.Failure<GetFacturasByFiltersRequest>(errors.ToImmutableArray())
                : request;
        }

    }
}
