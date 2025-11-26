using Domain.Models;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly FarmaceuticaContext _Context;

        public ProductoRepository(FarmaceuticaContext context)
        {
            _Context = context;
        }

        public async Task<List<Productos>> GetProductosAsync()
        {
            return await _Context.Productos.ToListAsync();
        }

        public async Task<List<InventariosProductos>> GetAllByFiltersAsync(Expression<Func<InventariosProductos, bool>> condicion)
        {
            return await _Context.InventariosProductos
               .Include(x => x.Producto.UnidadMedida)
               .Include(x => x.Producto.ClasificacionSuministro)
               .Include(x => x.Producto.InventariosProductos)
               .Include(x => x.Sucursal)
               .Where(condicion).ToListAsync();
        }

        public async Task<LotesProductos?> GetLoteProductoAsync(Expression<Func<LotesProductos, bool>> condicion)
        {
            return await _Context.LotesProductos
                .Include(x => x.Producto)
                .FirstOrDefaultAsync(condicion);
        }
    }
}
