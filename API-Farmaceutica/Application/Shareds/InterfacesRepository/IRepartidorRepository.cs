using Domain.Models;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface IRepartidorRepository
    {
        Task<List<Repartidores>> GetRepartidoresAsync();
    }
}
