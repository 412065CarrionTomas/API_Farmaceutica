using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface IProveedorRepository
    {
        public Task<List<Proveedores>> GetProveedoresFilterAsync(Expression<Func<Proveedores, bool>> condicion);
        public Task<bool> UpdateProveedoresAsync(string cuit, Proveedores proveedor);
        public Task<bool> InsertProveedorAsync(Proveedores proveedor);
        public Task<bool> DeleteProveedorAsync(string cuit);
    }
}
