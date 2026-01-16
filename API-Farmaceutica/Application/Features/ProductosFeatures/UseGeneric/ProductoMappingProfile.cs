using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductos;
using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductosByFilters;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.ProductosFeatures.UseGeneric
{
    public class ProductoMappingProfile : Profile
    {
        public ProductoMappingProfile()
        {
            //FEATURE GetAllProductos
            CreateMap<Productos, GetProductosResponse>();

            //FEATURE GetAllProductosByFilters
            CreateMap<Productos, GetProductosByFiltersResponse>();

        }
    }
}
