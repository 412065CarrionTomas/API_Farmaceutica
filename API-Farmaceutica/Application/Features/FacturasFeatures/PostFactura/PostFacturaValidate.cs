using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
using API_Farmaceutica.Application.Shareds.ROP;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Collections.Immutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura
{
    public static class PostFacturaValidate
    {
        public static Result<PostFacturaRequest> PostFacturaValidateRequest(PostFacturaRequest request)
        {
            List<string>? errors = new List<string>();
            if (request.Clienteid <= 0)
                errors.Add($"El id del {nameof(request.Clienteid)} no puede ser igual o menor a 0.");
            if (request.Empleadoid <= 0)
                errors.Add($"El id del {nameof(request.Empleadoid)} no puede ser igual o menor a 0.");
            if (request.Sucursalid <= 0)
                errors.Add($"El id del {nameof(request.Sucursalid)} no puede ser igual o menor a 0.");
            if (request.MetodoPagoid <= 0)
                errors.Add($"El id del {nameof(request.MetodoPagoid)} no puede ser igual o menor a 0.");
            if (request.DetalleFacturaDTO == null || !request.DetalleFacturaDTO.Any())
                errors.Add($"La {nameof(request.DetalleFacturaDTO)} no puede ser nula o vacía.");
            foreach(var detalle in request.DetalleFacturaDTO)
            {
                if (detalle is null)
                {
                    errors.Add("No puede ingresar detalles nulos.");
                    continue;
                }

                bool hasProductoId = detalle.Productoid.HasValue && detalle.Productoid > 0;
                bool hasMedicamentoId = detalle.Medicamentoid.HasValue && detalle.Medicamentoid > 0;

                if (hasMedicamentoId && hasProductoId)
                    errors.Add($"No puede ingresar un {nameof(detalle.Productoid)} y {nameof(detalle.Medicamentoid)}" +
                        $"al mismo tiempo.");
                if (!hasProductoId && !hasMedicamentoId)
                    errors.Add($"Debe ingresar o un {nameof(detalle.Medicamentoid)} o un {nameof(detalle.Productoid)}.");
                
                if (detalle.Cantidad <= 0)
                    errors.Add($"La {nameof(detalle.Cantidad)} no puede ser igual o menor a 0.");
                if (detalle.Precio <= 0)
                    errors.Add($"El {nameof(detalle.Precio)} no puede ser igual o menor a 0.");
                if (detalle.Coberturaid <= 0)
                    errors.Add($"El id del {nameof(detalle.Coberturaid)} no puede ser igual o menor a 0.");
                if (detalle.Descuentoid <= 0)
                    errors.Add($"El id del {nameof(detalle.Descuentoid)} no puede ser igual o menor a 0.");
            }
            return errors.Any()
                ? ResultExtension.Failure<PostFacturaRequest>(errors.ToImmutableArray())
                : request;
        }
    }
}
