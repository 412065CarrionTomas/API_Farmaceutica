using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters
{
    public class GetFacturasByFiltersHandler
    {
        private readonly IFacturaRepository _facturaRepository;
        private readonly IMapper _mapper;

        public GetFacturasByFiltersHandler(IMapper mapper, IFacturaRepository facturaRepository)
        {
            _mapper = mapper;
            _facturaRepository = facturaRepository;
        }

        public async Task<Result<List<GetFacturasByFiltersResponse>>> HandlerAsync(GetFacturasByFiltersRequest request)
        {
            return await GetFacturasByFiltersValidate.ValidateRequest(request)
                .Bind(ConsultaBDAsync)
                .Bind(Mapeo);
        }

        private async Task<Result<List<Facturas>>> ConsultaBDAsync(GetFacturasByFiltersRequest request)
        {
            Expression<Func<Facturas, bool>> condicion = x =>
            (request.FacturaID == null || x.Facturaid.Equals(request.FacturaID)) &&
            (request.SucursalID == null || x.Sucursalid.Equals(request.SucursalID)) &&
            (request.EmpleadoID == null || x.Empleadoid.Equals(request.EmpleadoID)) &&
            (request.MetodoPagoID == null || x.MetodoPagoid.Equals(request.MetodoPagoID));

            List<Facturas> facturasFilter = await _facturaRepository.GetFacturasByFiltersAsync(condicion);
            return facturasFilter;
        }
        private Result<List<GetFacturasByFiltersResponse>> Mapeo(List<Facturas> facturas)
        {
            List<GetFacturasByFiltersResponse> facturasDTO = _mapper.Map<List<GetFacturasByFiltersResponse>>(facturas);
            return facturasDTO;
        }
    }
}
