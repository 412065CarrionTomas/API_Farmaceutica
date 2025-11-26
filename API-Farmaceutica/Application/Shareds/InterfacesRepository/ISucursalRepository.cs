using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface ISucursalRepository
    {
        Task<List<Sucursales>?> GetSucursalesAsync(Expression<Func<Sucursales,bool>>? condicion);
    }
}
