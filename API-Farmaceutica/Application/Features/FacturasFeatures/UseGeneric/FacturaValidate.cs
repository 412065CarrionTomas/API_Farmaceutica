using API_Farmaceutica.Application.Shareds.ROP;
using Domain.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.UseGeneric
{
    public class FacturaValidate
    {
        private readonly FarmaceuticaContext _Context;
        public FacturaValidate(FarmaceuticaContext context)
        {
            _Context = context;
        }

        //public async Task<Result<bool>> Validate(Facturas request)
        //{

        //}
    }
}
