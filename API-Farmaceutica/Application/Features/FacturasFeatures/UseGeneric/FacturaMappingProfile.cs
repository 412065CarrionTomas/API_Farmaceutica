using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
using API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.UseGeneric
{
    public class FacturaMappingProfile : Profile
    {
        public FacturaMappingProfile()
        {
            //Feature GetFacturas
            CreateMap<DetallesFacturas, DetallesFacturaDTO>();


            CreateMap<Facturas, GetFacturaResponse>()
                .ForMember(dto => dto.DetallesFacturaDTO, src
                    => src.MapFrom(dom => dom.DetallesFacturas));

            //Feature GetFacturasByFilters
            CreateMap<DetallesFacturas, DetalleFacturaByFiltersDTO>();

            CreateMap<Facturas, GetFacturasByFiltersResponse>()
                .ForMember(dto => dto.DetalleFacturaDTO, src
                    => src.MapFrom(dom => dom.DetallesFacturas));

            //Feature PostFactura
            CreateMap<DetallesFacturasPost, DetallesFacturas>();

            CreateMap<PostFacturaRequest, Facturas>()
                .ForMember(dom => dom.DetallesFacturas, src
                => src.MapFrom(dto => dto.DetalleFacturaDTO));
        }
    }
}
