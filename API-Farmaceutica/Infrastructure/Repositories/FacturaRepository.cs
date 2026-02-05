using Domain.Models;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class FacturaRepository : IFacturaRepository
    {
        private readonly FarmaceuticaContext _context;
        public FacturaRepository(FarmaceuticaContext context)
        {
            _context = context;
        }

        public async Task<List<Facturas>> GetGananciasFacturasAsync(Expression<Func<Facturas, bool>> condicion)
        {
            return await _context.Facturas
                .Include(f => f.DetallesFacturas)
                .Where(condicion)
                .ToListAsync();
        }

        public async Task<List<sp_ganancias_mensualesResult>> GetGananciasMensualesAsync(int? anio)
            => await _context.Functions.sp_ganancias_mensualesAsync(anio);

        public async Task<List<Vwmedicamentotop>> GetMedicamentoTopAsync() 
            => await _context.Vwmedicamentotop.ToListAsync();

        public async Task<List<sp_mpusadosResult>> GetMPUsadosAsync(int? anio)
            => await _context.Functions.sp_mpusadosAsync(anio);
        public async Task<List<sp_ventas_por_sucursalResult>> GetVentasPorSucursalAsync(int? anio)
            => await _context.Functions.sp_ventas_por_sucursalAsync(anio);
        public async Task<List<Vwproductotop>> GetProductoTopAsync() 
            => await _context.Vwproductotop.ToListAsync();

        public async Task<List<Facturas>> GetFacturasAsync()
            => await _context.Facturas
            .AsNoTracking()
            .Include(x => x.DetallesFacturas)
            .ToListAsync();

        public async Task<List<Facturas>> GetFacturasByFiltersAsync(Expression<Func<Facturas, bool>> condicion)
            => await _context.Facturas
            .AsNoTracking()
            .Include(x => x.DetallesFacturas)
            .Where(condicion)
            .ToListAsync();

        public async Task<bool> InsertFacturaAsync(Facturas factura)
        {
            await _context.Facturas.AddAsync(factura);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateFacturaAsync(Facturas request, int id)
        {
            Facturas? facturaId = await _context.Facturas.FindAsync(id);
            if(facturaId == null) { return false; }
            facturaId.FechaFacturacion = request.FechaFacturacion;
            facturaId.Sucursalid = request.Sucursalid;
            facturaId.Empleadoid = request.Empleadoid;
            facturaId.Clienteid = request.Clienteid;
            facturaId.MetodoPagoid = request.MetodoPagoid;
            facturaId.DetallesFacturas = request.DetallesFacturas;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
