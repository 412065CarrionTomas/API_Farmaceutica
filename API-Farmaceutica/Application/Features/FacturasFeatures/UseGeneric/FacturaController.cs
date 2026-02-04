using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
using Microsoft.AspNetCore.Mvc;
using API_Farmaceutica.Application.Shareds.ROP;
using System.Runtime.ExceptionServices;
using API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.UseGeneric
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly GetFacturasHandler _Factura;
        private readonly GetFacturasByFiltersHandler _FacturaByFilters;
        private readonly PostFacturaHandler _PostFactura;

        public FacturaController(GetFacturasHandler factura, GetFacturasByFiltersHandler facturaByFilters, PostFacturaHandler postFactura)
        {
            _Factura = factura;
            _FacturaByFilters = facturaByFilters;
            _PostFactura = postFactura;
        }

        // GET: api/<FacturaController>
        [HttpGet("obtener_facturas")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _Factura.HandlerAsync();
                if (result.Value == null) { return NotFound("No se encontro ninguna factura registrada"); }
                return Ok(result.Value);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
            
        }

        // GET api/<FacturaController>/5
        [HttpGet("obtener_facturas_filtradas")]
        public async Task<IActionResult> Get([FromQuery] GetFacturasByFiltersRequest request)
        {
            try
            {
                Result<List<GetFacturasByFiltersResponse>> result = await _FacturaByFilters.HandlerAsync(request);
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

        // POST api/<FacturaController>
        [HttpPost("insertar_factura")]
        public async Task<IActionResult> Post([FromBody] PostFacturaRequest request)
        {
            try
            {
                if (request == null) { return BadRequest("Debe enviar un valor completo."); }
                var result = await _PostFactura.HandlerAsync(request);
                return result.IsSucces
                    ? Ok(result.Value)
                    : BadRequest(result.Errors);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }

    }
}
