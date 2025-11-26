using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface IDetalleCompraRepository
    {
        Task<List<DetallesCompras>?> GetAllDetallesComprasAsync(Expression<Func<DetallesCompras,bool>> condicion);
        Task<bool> UpdateCompraAsync(int id, DetallesCompras detalle, string entidad);
        Task<bool> InsertCompraAsync(int idCompra, DetallesCompras detalle, string entidad);
        Task<bool> DeleteCompraAsync(int id);
    }
}
