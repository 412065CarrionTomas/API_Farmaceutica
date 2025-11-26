using Domain.Models;
using System.Linq.Expressions;

namespace API_Farmaceutica.Application.Shareds.InterfacesRepository
{
    public interface IEmpleadoRepostiory
    {
        Task<List<Empleados>> GetEmpleadosAsync();
    }
}
