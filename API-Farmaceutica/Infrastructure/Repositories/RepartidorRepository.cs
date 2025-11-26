using Domain.Models;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Microsoft.EntityFrameworkCore;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class RepartidorRepository : IRepartidorRepository
    {
        private readonly FarmaceuticaContext _context;

        public RepartidorRepository(FarmaceuticaContext context)
        {
            _context = context;
        }

        public async Task<List<Repartidores>> GetRepartidoresAsync()
        {
            return await _context.Repartidores.ToListAsync();
        }
    }
}
