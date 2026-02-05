using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.JWTFeatures.Login
{
    public class LoginUsuarioHandler
    {
        private readonly IUsusarioRepository _UsuarioRepository;
        private readonly IMapper _Mapper;
        private readonly IConfiguration _Configuration;

        public LoginUsuarioHandler(IUsusarioRepository usuarioRepository, IMapper mapper, IConfiguration configuration)
        {
            _UsuarioRepository = usuarioRepository;
            _Mapper = mapper;
            _Configuration = configuration;
        }


        public async Task<Result<Usuarios>> HandlerAsync(GetUsuarioLoginRequest request)
        {
            return await GetUsuarioLoginValidate.ValidateRequest(request)
                .Bind(Mapeo)
                .Bind(ConsultaBDAsync);
        }

        private Result<Usuarios> Mapeo(GetUsuarioLoginRequest request)
        {
            Usuarios usuario = _Mapper.Map<Usuarios>(request);
            if (usuario == null)
                return ResultExtension.Failure<Usuarios>("Hubo un error en el mapeo.");
            return usuario;
        }

        private async Task<Result<Usuarios>> ConsultaBDAsync(Usuarios usuario)
        {
            try
            {
                Usuarios user = await _UsuarioRepository.LoginAsync(usuario);
                if(user == null)
                {
                    return ResultExtension.Failure<Usuarios>("Error al ingresar usuario o contrasenia.");
                }

                return user;
            }
            catch (Exception ex)
            {
                return ResultExtension.Failure<Usuarios>("Error en la BD " + ex.Message);
            }
        }

        

    }
}
