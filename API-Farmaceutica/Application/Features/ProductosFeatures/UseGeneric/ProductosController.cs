using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductos;
using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductosByFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ExceptionServices;

namespace API_Farmaceutica.Application.Features.ProductosFeatures.UseGeneric
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly GetProductosHandler _getProductosHandler;
        private readonly GetProductosByFiltersHandler _getProductoByFiltersHandler;

        public ProductosController(GetProductosHandler getProductosHandler
            , GetProductosByFiltersHandler getProductoByFiltersHandler)
        {
            _getProductosHandler = getProductosHandler;
            _getProductoByFiltersHandler = getProductoByFiltersHandler;
        }

        // GET: api/<ProductosController>
        [Authorize(Policy = "UserOrAdmin")]
        [HttpGet("obtener_productos")]
        public async Task<dynamic> GetAll()
        {

            try
            {
                var result = await _getProductosHandler.HandlerAsync();
                if(result.Value == null || result.Value.Count == 0) 
                { 
                    return NotFound(result.Errors); 
                }
                return Ok(result.Value);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }

        // GET api/<ProductosController>/5
        [Authorize(Policy = "UserOrAdmin")]
        [HttpPost("obtener_productos_filtrados")]
        public async Task<IActionResult> GetAllByFilters([FromBody] GetProductosByFiltersRequest request)
        {
            try
            {
                var result = await _getProductoByFiltersHandler.HandlerAsync(request);
                if(result.Value == null || result.Value.Count == 0)
                {
                    return NotFound(result.Errors);
                }
                return Ok(result.Value);
            }
            catch (Exception ex)
            {
                ExceptionDispatchInfo.Capture(ex).Throw();
                throw;
            }
        }
    }
}
