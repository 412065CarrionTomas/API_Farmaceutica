using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.FacturasFeatures
{
    public class GetFacturasHandler
    {
        private readonly IFacturaRepository _FacturaRepository;
        private readonly IMapper _Mapper;

        public GetFacturasHandler(IFacturaRepository facturaRepository, IMapper mapper)
        {
            _FacturaRepository = facturaRepository;
            _Mapper = mapper;
        }

        public async Task<Result<List<GetFacturaResponse>>> HandlerAsync()
        {
            List<Facturas> facturasLts = await _FacturaRepository.GetFacturasAsync();
            List<GetFacturaResponse> facturasResponseLts = _Mapper.Map<List<GetFacturaResponse>>(facturasLts);
            return facturasResponseLts;
        }
    }
}
