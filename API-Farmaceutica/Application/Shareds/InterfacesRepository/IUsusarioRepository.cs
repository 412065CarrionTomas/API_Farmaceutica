using API_Farmaceutica.Application.Features.JWTFeatures;
using API_Farmaceutica.Application.Shareds.ROP;
using Domain.Models;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface IUsusarioRepository
    {
        Task RegisterAsync(Usuarios request);
        Task<Usuarios> LoginAsync(Usuarios request);
    }
}
