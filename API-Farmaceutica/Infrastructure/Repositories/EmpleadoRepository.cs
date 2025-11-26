using Domain.Models;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class EmpleadoRepository : IEmpleadoRepostiory
    {
        private readonly FarmaceuticaContext _context;

        public EmpleadoRepository(FarmaceuticaContext context)
        {
            _context = context;
        }

        public async Task<List<Empleados>> GetEmpleadosAsync()
        {
            return await _context.Empleados.ToListAsync();
        }
    }
}
