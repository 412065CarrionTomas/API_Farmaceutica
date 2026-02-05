using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
using Microsoft.AspNetCore.Mvc;
using API_Farmaceutica.Application.Shareds.ROP;
using System.Runtime.ExceptionServices;
using API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura;
using Microsoft.AspNetCore.Authorization;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.UseGeneric
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly GetFacturasHandler _factura;
        private readonly GetFacturasByFiltersHandler _facturaByFilters;
        private readonly PostFacturaHandler _postFactura;

        public FacturaController(GetFacturasHandler factura, GetFacturasByFiltersHandler facturaByFilters, PostFacturaHandler postFactura)
        {
            _factura = factura;
            _facturaByFilters = facturaByFilters;
            _postFactura = postFactura;
        }

        // GET: api/<FacturaController>
        [Authorize(Policy = "UserOrAdmin")]
        [HttpGet("obtener_facturas")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _factura.HandlerAsync();
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
        [Authorize(Policy = "UserOrAdmin")]
        [HttpGet("obtener_facturas_filtradas")]
        public async Task<IActionResult> Get([FromQuery] GetFacturasByFiltersRequest request)
        {
            try
            {
                Result<List<GetFacturasByFiltersResponse>> result = await _facturaByFilters.HandlerAsync(request);
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
        [Authorize(Policy = "AdminOnly")]
        [HttpPost("insertar_factura")]
        public async Task<IActionResult> Post([FromBody] PostFacturaRequest request)
        {
            try
            {
                if (request == null) { return BadRequest("Debe enviar un valor completo."); }
                var result = await _postFactura.HandlerAsync(request);
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
