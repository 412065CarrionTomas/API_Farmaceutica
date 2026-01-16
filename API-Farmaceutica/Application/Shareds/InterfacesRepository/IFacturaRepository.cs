using API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura;
using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface IFacturaRepository
    {
        Task<List<Facturas>> GetGananciasFacturasAsync(Expression<Func<Facturas, bool>> condicion);
        Task<List<Vwproductotop>> GetProductoTopAsync();
        Task<List<Vwmedicamentotop>> GetMedicamentoTopAsync();
        Task<List<sp_ganancias_mensualesResult>> GetGananciasMensualesAsync(int? anio);
        Task<List<sp_mpusadosResult>> GetMPUsadosAsync(int? anio);
        Task<List<sp_ventas_por_sucursalResult>> GetVentasPorSucursalAsync(int? anio);
        Task<List<Facturas>> GetFacturasAsync();
        Task<List<Facturas>> GetFacturasByFiltersAsync(Expression<Func<Facturas,bool>> condicion);
        Task<bool> InsertFacturaAsync(Facturas request);
        Task<bool> UpdateFacturaAsync(Facturas request, int id);
    }
}
