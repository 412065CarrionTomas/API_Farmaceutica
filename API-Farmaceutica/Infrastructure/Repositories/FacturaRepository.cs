using Domain.Models;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class FacturaRepository : IFacturaRepository
    {
        private readonly FarmaceuticaContext _Context;
        public FacturaRepository(FarmaceuticaContext context)
        {
            _Context = context;
        }

        public async Task<List<Facturas>> GetGananciasFacturasAsync(Expression<Func<Facturas, bool>> condicion)
        {
            return await _Context.Facturas
                .Include(f => f.DetallesFacturas)
                .Where(condicion)
                .ToListAsync();
        }

        public async Task<List<sp_ganancias_mensualesResult>> GetGananciasMensualesAsync(int? anio)
            => await _Context.Functions.sp_ganancias_mensualesAsync(anio);

        public async Task<List<Vwmedicamentotop>> GetMedicamentoTopAsync() 
            => await _Context.Vwmedicamentotop.ToListAsync();

        public async Task<List<sp_mpusadosResult>> GetMPUsadosAsync(int? anio)
            => await _Context.Functions.sp_mpusadosAsync(anio);
        public async Task<List<sp_ventas_por_sucursalResult>> GetVentasPorSucursalAsync(int? anio)
            => await _Context.Functions.sp_ventas_por_sucursalAsync(anio);
        public async Task<List<Vwproductotop>> GetProductoTopAsync() 
            => await _Context.Vwproductotop.ToListAsync();

        public async Task<List<Facturas>> GetFacturasAsync()
            => await _Context.Facturas
            .AsNoTracking()
            .Include(x => x.DetallesFacturas)
            .ToListAsync();

        public async Task<List<Facturas>> GetFacturasByFiltersAsync(Expression<Func<Facturas, bool>> condicion)
            => await _Context.Facturas
            .AsNoTracking()
            .Include(x => x.DetallesFacturas)
            .Where(condicion)
            .ToListAsync();

        public async Task<bool> InsertFacturaAsync(Facturas factura)
        {
            await _Context.Facturas.AddAsync(factura);

            return await _Context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateFacturaAsync(Facturas request, int id)
        {
            Facturas? facturaId = await _Context.Facturas.FindAsync(id);
            if(facturaId == null) { return false; }
            facturaId.FechaFacturacion = request.FechaFacturacion;
            facturaId.Sucursalid = request.Sucursalid;
            facturaId.Empleadoid = request.Empleadoid;
            facturaId.Clienteid = request.Clienteid;
            facturaId.MetodoPagoid = request.MetodoPagoid;
            facturaId.DetallesFacturas = request.DetallesFacturas;
            return await _Context.SaveChangesAsync() > 0;
        }
    }
}
