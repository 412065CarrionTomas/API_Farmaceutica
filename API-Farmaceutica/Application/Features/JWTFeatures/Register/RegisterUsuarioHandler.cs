using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
using AutoMapper;
using Domain.Models;

namespace API_Farmaceutica.Application.Features.JWTFeatures.Register
{
    public class RegisterUsuarioHandler
    {
        private readonly IUsusarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public RegisterUsuarioHandler(IUsusarioRepository usuarioRepository, IMapper mapper, IConfiguration configuration)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<Result<string>> HandlerAsync(GetUsuarioRegisterRequest request)
        {
            return await GetUsuarioRegisterValidate.ValidateRequest(request)
                .Bind(DeterminarRol)
                .Bind(Mapeo)
                .Bind(ConsultaBDAsync);
        }
        private async Task<Result<string>> ConsultaBDAsync(Usuarios usuario)
        {
            try
            {
                await _usuarioRepository.RegisterAsync(usuario);
                return "Registrado!";
            }
            catch (Exception ex)
            {
                return ResultExtension.Failure<string>("Error en la BD " + ex.Message);
            }
        }

        private Result<Usuarios> Mapeo(GetUsuarioRegisterRequest request)
        {
            Usuarios usuario = _mapper.Map<Usuarios>(request);
            if (usuario == null)
                return ResultExtension.Failure<Usuarios>("Error en el mapeo.");
            usuario.Rol = request.Rol;
            return usuario;
        }

        private Result<GetUsuarioRegisterRequest> DeterminarRol(GetUsuarioRegisterRequest request)
        {
            string? adminSecretKey = _configuration["AdminRegistration:SecretKey"] ?? null;

            if(request.AdminSecretKey != null)
            {
                if(request.AdminSecretKey == adminSecretKey)
                {
                    request = request with { AdminSecretKey = null, Rol = "Admin"};
                    return request;
                }
                else
                {
                    return ResultExtension.Failure<GetUsuarioRegisterRequest>("Clave de administrador incorrecta.");
                }
            }

            return request with { Rol = "User"};
        }
    }
}
