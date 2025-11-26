using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface IMedicamentoRepository
    {
        Task<List<InventariosMedicamentos>?> GetAllByFiltersAsync(Expression<Func<InventariosMedicamentos, bool>> condicion);
        Task<LotesMedicamentos?> GetLoteMedicamentoAsync(Expression<Func<LotesMedicamentos, bool>> condicion);
    }
}
