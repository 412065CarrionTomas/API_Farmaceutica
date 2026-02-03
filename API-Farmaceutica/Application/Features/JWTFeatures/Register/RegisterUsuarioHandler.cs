using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.JWTFeatures.Register
{
    public class RegisterUsuarioHandler
    {
        private readonly IUsusarioRepository _UsuarioRepository;
        private readonly IMapper _Mapper;
        public RegisterUsuarioHandler(IUsusarioRepository usuarioRepository, IMapper mapper)
        {
            _UsuarioRepository = usuarioRepository;
            _Mapper = mapper;
        }

        public async Task<Result<string>?> HandlerAsync(GetUsuarioRegisterRequest request)
        {
            return await GetUsuarioRegisterValidate.ValidateRequest(request)
                .Bind(Mapeo)
                .Bind(ConsultaBDAsync);
        }
        private async Task<Result<string>> ConsultaBDAsync(Usuarios usuario)
        {
            try
            {
                await _UsuarioRepository.RegisterAsync(usuario);
                return "Registrado!";
            }
            catch (Exception ex)
            {
                return ResultExtension.Failure<string>("Error en la BD " + ex.Message);
            }
        }

        private Result<Usuarios> Mapeo(GetUsuarioRegisterRequest request)
        {
            Usuarios usuario = _Mapper.Map<Usuarios>(request);
            if (usuario == null)
                ResultExtension.Failure<Usuarios>("Error en el mapeo.");
            return usuario;
        }
    }
}
