using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Features.ProductosFeatures.GetProductosByFilters
{
    public class GetProductosByFiltersHandler
    {
        private readonly IProductoRepository _ProductoRepository;
        private readonly IMapper _Mapper;

        public GetProductosByFiltersHandler(IProductoRepository productoRepository, IMapper mapper)
        {
            _ProductoRepository = productoRepository;
            _Mapper = mapper;
        }

        public async Task<Result<List<GetProductosByFiltersResponse>>> HandlerAsync(GetProductosByFiltersRequest request)
        {
            return await GetProductosByFiltersValidate.ValidateRequest(request)
                .Bind(ConsultaBDAsync)
                .Bind(Mapeo);
        }

        private async Task<Result<List<Productos>>> ConsultaBDAsync(GetProductosByFiltersRequest request)
        {
            Expression<Func<Productos, bool>> condicion = x =>
            (request.ProductoId.Equals(null) || x.Productoid.Equals(request.ProductoId)) &&

            (string.IsNullOrEmpty(request.CodigoDeBarraDelProducto)
                || x.CodigoBarraProductoid.Contains(request.CodigoDeBarraDelProducto)) &&

            (string.IsNullOrEmpty(request.NombreDelProducto)
                || x.NombreProducto.Contains(request.NombreDelProducto)) &&

            (x.Activo.Equals(request.Activo)) &&

            (request.PrecioInicial.Equals(null) ? x.PrecioProducto >= 0
                                                : x.PrecioProducto >= request.PrecioInicial) &&

            (request.PrecioFinal.Equals(null) ? x.PrecioProducto >= 0
                                              : x.PrecioProducto <= request.PrecioFinal);

            try
            {
                var result = await _ProductoRepository.GetAllProductosByFiltersAsync(condicion);
                return result;
            }
            catch (Exception ex)
            {
                return ResultExtension.Failure<List<Productos>>("Error en la BD " + ex.Message);
            }

        }

        private Result<List<GetProductosByFiltersResponse>> Mapeo(List<Productos> entitys )
        {
            var result = _Mapper.Map<List<GetProductosByFiltersResponse>>(entitys);
            if(result == null)
            {
                return ResultExtension.Failure<List<GetProductosByFiltersResponse>>("Error en el mapeo.");
            }
            return result;
        }


    }
}
