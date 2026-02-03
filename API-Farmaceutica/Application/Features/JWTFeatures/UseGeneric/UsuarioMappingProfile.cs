using API_Farmaceutica.Application.Features.JWTFeatures.Login;
using API_Farmaceutica.Application.Features.JWTFeatures.Register;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.JWTFeatures.UseGeneric
{
    public class UsuarioMappingProfile : Profile
    {
        public UsuarioMappingProfile()
        {
            CreateMap<GetUsuarioRegisterRequest, Usuarios>();

            CreateMap<GetUsuarioLoginRequest, Usuarios>();
        }

    }
}
