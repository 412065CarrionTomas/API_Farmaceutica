using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductos;
using API_Farmaceutica.Application.Features.ProductosFeatures.GetProductosByFilters;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ExceptionServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Farmaceutica.Application.Features.ProductosFeatures.UseGeneric
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly GetProductosHandler _GetProductosHandler;
        private readonly GetProductosByFiltersHandler _GetProductoByFiltersHandler;

        public ProductosController(GetProductosHandler getProductosHandler
            , GetProductosByFiltersHandler getProductoByFiltersHandler)
        {
            _GetProductosHandler = getProductosHandler;
            _GetProductoByFiltersHandler = getProductoByFiltersHandler;
        }

        // GET: api/<ProductosController>
        [HttpGet("obtener_productos")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _GetProductosHandler.HandlerAsync();
                if(result.Value == null || result.Value.Count == 0) 
                { 
                    return NotFound("No se encontro ningun producto."); 
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
        [HttpPost("obtener_productos_filtrados")]
        public async Task<IActionResult> GetAllByFilters([FromBody] GetProductosByFiltersRequest request)
        {
            try
            {
                var result = await _GetProductoByFiltersHandler.HandlerAsync(request);
                if(result.Value == null || result.Value.Count == 0)
                {
                    return NotFound("No se encontro ningun producto con esos filtros.");
                }
                return Ok(result.Value);
            }
            catch (Exception ex)
            {
                ExceptionDispatchInfo.Capture(ex).Throw();
                throw;
            }
        }

        //// POST api/<ProductosController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProductosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
