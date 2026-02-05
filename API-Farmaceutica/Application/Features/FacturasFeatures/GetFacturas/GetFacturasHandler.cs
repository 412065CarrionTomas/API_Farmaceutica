using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.FacturasFeatures
{
    public class GetFacturasHandler
    {
        private readonly IFacturaRepository _facturaRepository;
        private readonly IMapper _mapper;

        public GetFacturasHandler(IFacturaRepository facturaRepository, IMapper mapper)
        {
            _facturaRepository = facturaRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<GetFacturaResponse>>> HandlerAsync()
        {
            return await ConsultaBDAsync()
                .Bind(Mapeo);
        }

        private async Task<Result<List<Facturas>>> ConsultaBDAsync()
        {
            try
            {
                return await _facturaRepository.GetFacturasAsync();
            }
            catch (Exception e)
            {
                return ResultExtension.Failure<List<Facturas>>($"ERROR en BD:{e.Message}");
            }
        }
        
        private Result<List<GetFacturaResponse>> Mapeo(List<Facturas> entitys)
        {
            List<GetFacturaResponse> result = _mapper.Map<List<GetFacturaResponse>>(entitys);
            if(result == null)
            {
                return ResultExtension.Failure<List<GetFacturaResponse>>("ERROR en el mapeo");
            }
            return result;
        }
    }
}
