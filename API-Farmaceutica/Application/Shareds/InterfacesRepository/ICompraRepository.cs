using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface ICompraRepository
    {
        Task<List<Compras>?> GetComprasAsync(Expression<Func<Compras, bool>> condicion);
        Task<bool> UpdateCompraAsync(int id, Compras compras);
        Task<bool> InsertCompraAsync(Compras compras);
        Task<bool> DeleteCompraAsync(int id);

    }
}
