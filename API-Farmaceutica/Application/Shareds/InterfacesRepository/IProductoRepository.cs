using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface IProductoRepository
    {
        Task<List<Productos>> GetProductosAsync();
        Task<List<InventariosProductos>> GetAllByFiltersAsync(Expression<Func<InventariosProductos, bool>> condicion);
        Task<LotesProductos?> GetLoteProductoAsync(Expression<Func<LotesProductos, bool>> condicion);

    }
}
