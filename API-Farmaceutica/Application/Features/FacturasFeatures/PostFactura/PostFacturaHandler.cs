using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura
{
    public class PostFacturaHandler
    {
        private readonly IMapper _mapper;
        private readonly IFacturaRepository _facturaRepository;

        public PostFacturaHandler(IMapper mapper, IFacturaRepository facturaRepository)
        {
            _mapper = mapper;
            _facturaRepository = facturaRepository;
        }

        public async Task<Result<string>> HandlerAsync(PostFacturaRequest request)
        {
            return await PostFacturaValidate.ValidateRequest(request)
                .Bind(Mapeo)
                .Bind(ConsultaBDAsync);
        }

        private async Task<Result<string>> ConsultaBDAsync(Facturas request)
        {
            try
            {
                if(request.FechaFacturacion == null || request.FechaFacturacion.Equals("")) 
                { request.FechaFacturacion = DateTime.Now; }
                bool result = await _facturaRepository.InsertFacturaAsync(request);
                return result
                    ? "Factura insertada exitosamente."
                    : ResultExtension.Failure<string>("No se pudo insertar la factura en la BD.");
            }
            catch (Exception ex)
            {
                return ResultExtension.Failure<string>($"Error en BD: {ex.Message}");
            }
        }

        private Result<Facturas> Mapeo(PostFacturaRequest request)
        {
            Facturas facturas = _mapper.Map<Facturas>(request);
            return (facturas != null)
                ? facturas
                : ResultExtension.Failure<Facturas>("El mapeo generó un objeto inválido.");
        }


    }
}
