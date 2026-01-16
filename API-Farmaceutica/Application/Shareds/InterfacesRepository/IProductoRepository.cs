using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository;

public interface IProductoRepository
{
    Task<List<Productos>> GetAllProductosAsync();
    Task<List<Productos>> GetAllProductosByFiltersAsync(Expression<Func<Productos, bool>> condicion);
    Task<bool> InsertProductoAsync(Productos entity);
    Task<bool> UpdateProductoAsync(int id, Productos entity);
    Task<bool> DeleteProductoAsync(int id);
}
