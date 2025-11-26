using Domain.Models;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class DetalleCompraRepository : IDetalleCompraRepository
    {
        private readonly FarmaceuticaContext _Context;

        public DetalleCompraRepository(FarmaceuticaContext context)
        {
            _Context = context;
        }

        public async Task<bool> DeleteCompraAsync(int id)
        {
            var detalle = await _Context.DetallesCompras
                .FirstOrDefaultAsync(d => d.DetalleCompraid == id);

            if (detalle == null) return false;

            detalle.Activo = false;
            return await _Context.SaveChangesAsync() > 0;
        }

        public async Task<List<DetallesCompras>?> GetAllDetallesComprasAsync(Expression<Func<DetallesCompras, bool>> condicion)
        {
            return await _Context.DetallesCompras
                .Where(condicion)
                .ToListAsync();
        }

        public async Task<bool> InsertCompraAsync(int compraId, DetallesCompras detalle, string entidad)
        {
            Compras? compraExiste = await _Context.Compras.FirstAsync(c => c.Compraid == compraId);

            if (compraExiste == null)
                return false;

            var codBarraProducto = new OutputParameter<string?>();
            var codBarraMedicamento = new OutputParameter<string?>();
            var loteMedicamento = new OutputParameter<int?>();
            var loteProducto = new OutputParameter<int?>();

            await _Context.Functions.sp_traer_tablas_detalleAsync(detalle.CodigoBarraProductoid
                , detalle.CodigoBarraMedicamentoid
                , detalle.LoteMedicamentoid
                , detalle.LoteProductoid
                , codBarraProducto
                , codBarraMedicamento
                , loteMedicamento
                , loteProducto);

            if(entidad == "p")
            {
                if (codBarraProducto.Value == null)
                    throw new ArgumentException("Codigo-Barra de Producto no encontrado");
                if (loteProducto.Value == null)
                    throw new ArgumentException("Lote Producto no encontrado");
            }
            
            if (entidad == "m")
            {
                if (loteMedicamento.Value == null)
                    throw new ArgumentException("Lote Medicamento no encontrado");
                if (codBarraMedicamento.Value == null)
                    throw new ArgumentException("Codigo-Barra de Medicamento no encontrado");
            }

            detalle.Compraid = compraId;

            await _Context.DetallesCompras.AddAsync(detalle);
            return await _Context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateCompraAsync(int id, DetallesCompras detalle, string entidad)
        {
            var actual = await _Context.DetallesCompras
                .FirstOrDefaultAsync(d => d.DetalleCompraid == id);

            if (actual == null) return false;

            var codBarraProducto = new OutputParameter<string?>();
            var codBarraMedicamento = new OutputParameter<string?>();
            var loteMedicamento = new OutputParameter<int?>();
            var loteProducto = new OutputParameter<int?>();

            await _Context.Functions.sp_traer_tablas_detalleAsync(detalle.CodigoBarraProductoid
                , detalle.CodigoBarraMedicamentoid
                , detalle.LoteMedicamentoid
                , detalle.LoteProductoid
                , codBarraProducto
                , codBarraMedicamento
                , loteMedicamento
                , loteProducto);

            if (entidad == "p")
            {
                if (codBarraProducto.Value == null)
                    throw new ArgumentException("Codigo-Barra de Producto no encontrado");
                if (loteProducto.Value == null)
                    throw new ArgumentException("Lote Producto no encontrado");
            }

            if (entidad == "m")
            {
                if (loteMedicamento.Value == null)
                    throw new ArgumentException("Lote Medicamento no encontrado");
                if (codBarraMedicamento.Value == null)
                    throw new ArgumentException("Codigo-Barra de Medicamento no encontrado");
            }

            actual.CodigoBarraProductoid = detalle.CodigoBarraProductoid;
            actual.CodigoBarraMedicamentoid = detalle.CodigoBarraMedicamentoid;
            actual.LoteProductoid= detalle.LoteProductoid;
            actual.LoteMedicamentoid= detalle.LoteMedicamentoid;
            actual.Cantidad = detalle.Cantidad;
            actual.Activo = detalle.Activo ?? actual.Activo;

            return await _Context.SaveChangesAsync() > 0;
        }
    }
}
