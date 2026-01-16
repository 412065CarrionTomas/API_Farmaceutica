using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Domain.Models;
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

        public Task<bool> DeleteProductoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Productos>> GetAllProductosAsync()
        {
            return await _Context.Productos
                .Include(x => x.TipoSuministro)
                .Include(x => x.TipoPresentacion)
                .Include(x => x.ClasificacionSuministro)
                .Include(x => x.UnidadMedida)
                .ToListAsync();
        }

        public async Task<List<Productos>> GetAllProductosByFiltersAsync(Expression<Func<Productos, bool>> condicion)
        {
            return await _Context.Productos
                .Include(x => x.TipoSuministro)
                .Include(x => x.TipoPresentacion)
                .Include(x => x.ClasificacionSuministro)
                .Include(x => x.UnidadMedida)
                .Where(condicion)
                .ToListAsync();
        }

        public Task<bool> InsertProductoAsync(Productos entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProductoAsync(int id, Productos entity)
        {
            throw new NotImplementedException();
        }
    }
}
