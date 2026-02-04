using API_Farmaceutica.Application.Shareds.ROP;
using System.Collections.Immutable;

namespace API_Farmaceutica.Application.Features.ProductosFeatures.GetProductosByFilters
{
    public static class GetProductosByFiltersValidate
    {
        public static Result<GetProductosByFiltersRequest> ValidateRequest(GetProductosByFiltersRequest request)
        {
            List<string> errors = new List<string>();
            if (request == null)
                errors.Add("Debes mandar un cuerpo de filtro.");
            if (request.ProductoId <= 0)
                errors.Add($"No puedes ingresar un {nameof(request.ProductoId)} menor o igual a 0.");

            bool hasPrecioInical = request.PrecioInicial.HasValue;
            bool hasPrecioFinal = request.PrecioFinal.HasValue;
            
            if (hasPrecioFinal && hasPrecioFinal && request.PrecioFinal < request.PrecioInicial)
                errors.Add($"El {nameof(request.PrecioInicial)} debe ser mayor a " +
                    $"el {nameof(request.PrecioFinal)}.");

            return errors.Any()
                ? ResultExtension.Failure<GetProductosByFiltersRequest>(errors.ToImmutableArray())
                : request;

        }
    }
}
