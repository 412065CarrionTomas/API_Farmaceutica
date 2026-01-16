using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters
{
    public class GetFacturasByFiltersHandler
    {
        private readonly IFacturaRepository _FacturaRepository;
        private readonly IMapper _Mapper;

        public GetFacturasByFiltersHandler(IMapper mapper, IFacturaRepository facturaRepository)
        {
            _Mapper = mapper;
            _FacturaRepository = facturaRepository;
        }

        public async Task<Result<List<GetFacturasByFiltersResponse>>> GetFacturasHandlerAsync(GetFacturasByFiltersRequest request)
        {
            return await GetFacturasByFiltersValidate.GetFacturasByFiltersValidateRequest(request)
                .Bind(ConsultaBD)
                .Bind(Mapeo);
        }

        private async Task<Result<List<Facturas>>> ConsultaBD(GetFacturasByFiltersRequest request)
        {
            Expression<Func<Facturas, bool>> condicion = x =>
            (request.FacturaID == null || x.Facturaid.Equals(request.FacturaID)) &&
            (request.SucursalID == null || x.Sucursalid.Equals(request.SucursalID)) &&
            (request.EmpleadoID == null || x.Empleadoid.Equals(request.EmpleadoID)) &&
            (request.MetodoPagoID == null || x.MetodoPagoid.Equals(request.MetodoPagoID));

            List<Facturas> facturasFilter = await _FacturaRepository.GetFacturasByFiltersAsync(condicion);
            return facturasFilter;
        }
        private Result<List<GetFacturasByFiltersResponse>> Mapeo(List<Facturas> facturas)
        {
            List<GetFacturasByFiltersResponse> facturasDTO = _Mapper.Map<List<GetFacturasByFiltersResponse>>(facturas);
            return facturasDTO;
        }
        //primero filtrar,pasar a la bd y luego mapear. analizar como hacer para que se inteligente
        //y escalable
    }
}
