using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.PutFactura
{
    public class PutFacturaHandler
    {
        private readonly IMapper _Mapper;
        private readonly IFacturaRepository _FacturaRepository;

        public PutFacturaHandler(IFacturaRepository facturaRepository, IMapper mapper)
        {
            _FacturaRepository = facturaRepository;
            _Mapper = mapper;
        }

        public async Task<Result<string>> PutFacturaHandlerAsync(PutFacturaRequest request)
        {
            return await PutFacturaValidate.PutFacturaValidateRequest(request)
                .Bind(Mapeo)
                .Bind(ConsultaBDAsync);
        }
        
        private Result<Facturas> Mapeo(PutFacturaRequest request)
        {
            Facturas? factura = _Mapper.Map<Facturas>(request);
            bool result = factura == null || factura.Facturaid <= 0;

            return result
                ? factura
                : ResultExtension.Failure<Facturas>("Error al mapear la entidad.");
        }

        private async Task<Result<string>> ConsultaBDAsync(Facturas request)
        {
            try
            {
                bool result = await _FacturaRepository.UpdateFacturaAsync(request, request.Facturaid);
                return result
                    ? "Exito al cargar usuario"
                    : ResultExtension.Failure<string>("Hubo un error al cargar el usuario en la BD.");
            }
            catch (Exception ex)
            {
                return ResultExtension.Failure<string>($"Error en BD: {ex.Message}");
            }
            
        } 

    }
}
