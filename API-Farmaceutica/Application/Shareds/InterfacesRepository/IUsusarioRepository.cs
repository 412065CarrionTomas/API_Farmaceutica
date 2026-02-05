using API_Farmaceutica.Application.Features.JWTFeatures;
using API_Farmaceutica.Application.Shareds.ROP;
using Domain.Models;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface IUsusarioRepository
    {
        Task<Usuarios> GetUsuarioByGuid(Guid userId);
        Task RegisterAsync(Usuarios usuario);
        Task<Usuarios> LoginAsync(Usuarios usuario);

        Task UpdateUsuario(Usuarios usuario);
    }
}
