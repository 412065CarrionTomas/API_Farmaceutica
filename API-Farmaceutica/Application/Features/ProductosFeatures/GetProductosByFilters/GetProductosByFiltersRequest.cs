namespace API_Farmaceutica.Application.Features.ProductosFeatures.GetProductosByFilters
{
    public record GetProductosByFiltersRequest
    {
        public int? ProductoId { get; init; }
        public string? CodigoDeBarraDelProducto { get; init; }
        public string? NombreDelProducto { get; init; }
        public decimal? PrecioInicial { get; init; }
        public decimal? PrecioFinal { get; set; }
        public bool? Activo { get; init; }

    }
}
