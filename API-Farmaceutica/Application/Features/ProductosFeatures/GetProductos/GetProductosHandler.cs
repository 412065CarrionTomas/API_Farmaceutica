using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;
using System.Runtime.ExceptionServices;

namespace API_Farmaceutica.Application.Features.ProductosFeatures.GetProductos
{
    public class GetProductosHandler
    {
        private readonly IProductoRepository _ProductoRepository;
        private readonly IMapper _Mapper;

        public GetProductosHandler(IProductoRepository productoRepository, IMapper mapper)
        {
            _ProductoRepository = productoRepository;
            _Mapper = mapper;
        }

        public async Task<Result<List<GetProductosResponse>>> HandlerAsync()
        {
            return await ConsultaBDAsync()
                .Bind(Mapeo);
        }

        private Result<List<GetProductosResponse>> Mapeo(List<Productos> entitys)
        {
            List<GetProductosResponse> result = _Mapper.Map<List<GetProductosResponse>>(entitys);
            if(result == null)
            {
                return ResultExtension.Failure<List<GetProductosResponse>>("Error en el mapeo.");
            }
            return result;
        }

        private async Task<Result<List<Productos>>> ConsultaBDAsync()
        {
            try
            {
                return await _ProductoRepository.GetAllProductosAsync();
            }
            catch (Exception e)
            {
                return ResultExtension.Failure<List<Productos>>($"Error en BD: {e.Message}");
            }
        }
    }
}
