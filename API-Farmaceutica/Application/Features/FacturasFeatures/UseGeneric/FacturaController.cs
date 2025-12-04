using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
using Microsoft.AspNetCore.Mvc;
using API_Farmaceutica.Application.Shareds.ROP;
using System.Runtime.ExceptionServices;
using Microsoft.VisualBasic;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.UseGeneric
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly GetFacturasHandler _Factura;
        private readonly GetFacturasByFiltersHandler _FacturaByFilters;

        public FacturaController(GetFacturasHandler factura, GetFacturasByFiltersHandler facturaByFilters)
        {
            _Factura = factura;
            _FacturaByFilters = facturaByFilters;
        }

        // GET: api/<FacturaController>
        [HttpGet("obtener_facturas")]
        public async Task<IActionResult> Get()
        {
            var result = await _Factura.HandlerAsync();
            if(result.Value == null) { return NotFound("No se encontro ninguna factura registrada"); }
            return Ok(result.Value);
        }

        // GET api/<FacturaController>/5
        [HttpGet("obtener_facturas_filtradas")]
        public async Task<IActionResult> Get([FromQuery] GetFacturasByFiltersRequest request)
        {
            try
            {
                Result<List<GetFacturasByFiltersResponse>> result = await _FacturaByFilters.GetFacturasHandlerAsync(request);
                return result.IsSucces
                    ? Ok(result.Value)
                    : Ok(result.Errors);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }

        //// POST api/<FacturaController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<FacturaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<FacturaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
