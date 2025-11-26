using Domain.Models;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly FarmaceuticaContext _Context;

        public ProveedorRepository(FarmaceuticaContext context)
        {
            _Context = context;
        }
        public async Task<bool> DeleteProveedorAsync(string cuit)
        {
            Proveedores? proveedor = await _Context.Proveedores
                                    .FirstAsync(x => x.Cuit.Equals(cuit));
            if (proveedor == null) { throw new InvalidOperationException(); }
            proveedor.Activo = false;

            return await _Context.SaveChangesAsync() > 0;
        }

        public async Task<List<Proveedores>> GetProveedoresFilterAsync(Expression<Func<Proveedores, bool>> condicion)
        {
            return await _Context.Proveedores
                        .Where(condicion).ToListAsync();
        }

        public async Task<bool> InsertProveedorAsync(Proveedores proveedor)
        {
            await _Context.Proveedores.AddAsync(proveedor);
            return await _Context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateProveedoresAsync(string cuit, Proveedores proveedor)
        {
            var objTrack = await _Context.Proveedores.FirstOrDefaultAsync(x => x.Cuit == cuit);
            if (objTrack == null) return false;

            objTrack.Razonsocial = proveedor.Razonsocial;
            objTrack.Cuit = proveedor.Cuit;
            objTrack.Emailproveedor = proveedor.Emailproveedor;
            objTrack.Telefonoproveedor = proveedor.Telefonoproveedor;
            objTrack.Activo = proveedor.Activo;

            return await _Context.SaveChangesAsync() > 0;
        }
    }
}
