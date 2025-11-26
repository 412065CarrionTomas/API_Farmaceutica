using Domain.Models;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class MedicamentoRepository : IMedicamentoRepository
    {
        private readonly FarmaceuticaContext _Context;

        public MedicamentoRepository(FarmaceuticaContext context)
        {
            _Context = context;
        }

        public async Task<List<InventariosMedicamentos>?> GetAllByFiltersAsync(Expression<Func<InventariosMedicamentos, bool>> condicion)
        {
            return await _Context.InventariosMedicamentos
                .Include(x => x.Medicamento.UnidadMedida)
                .Include(x => x.Medicamento.ClasificacionSuministro)
                .Include(x => x.Medicamento.Restriccion)
                .Include(x => x.Medicamento.InventariosMedicamentos)
                .Include(x => x.Sucursal)
                .Where(condicion).ToListAsync();
        }

        public async Task<LotesMedicamentos?> GetLoteMedicamentoAsync(Expression<Func<LotesMedicamentos, bool>> condicion)
        {
            return await _Context.LotesMedicamentos
                .Include(x => x.Medicamento)
                .FirstOrDefaultAsync(condicion);
        }
    }
}
