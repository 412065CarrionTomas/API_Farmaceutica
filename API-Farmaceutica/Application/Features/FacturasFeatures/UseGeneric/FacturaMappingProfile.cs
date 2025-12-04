using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
using AutoMapper;
using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.UseGeneric
{
    public class FacturaMappingProfile : Profile
    {
        public FacturaMappingProfile()
        {
            //Feature GetFacturas
            CreateMap<DetallesFacturaDTO, DetallesFacturas>();

            CreateMap<Facturas, GetFacturaResponse>()
                .ForMember(dto => dto.DetallesFacturaDTO, src
                    => src.MapFrom(dom => dom.DetallesFacturas));

            //Feature GetFacturasByFilters
            CreateMap<DetallesFacturas, DetalleFacturaByFiltersDTO>();

            CreateMap<Facturas, GetFacturasByFiltersResponse>()
                .ForMember(dto => dto.DetalleFacturaDTO, src
                    => src.MapFrom(dom => dom.DetallesFacturas));
        }
    }
}
