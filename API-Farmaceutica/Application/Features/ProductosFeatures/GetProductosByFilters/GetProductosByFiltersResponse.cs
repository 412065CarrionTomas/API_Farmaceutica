namespace API_Farmaceutica.Application.Features.ProductosFeatures.GetProductosByFilters
{
    public record GetProductosByFiltersResponse
    {
        public int Productoid { get; set; }

        public string? CodigoBarraProductoid { get; set; }

        public string? NombreProducto { get; set; }

        public decimal? PrecioProducto { get; set; }

        public int? TipoSuministroid { get; set; }

        public int? ClasificacionSuministroid { get; set; }

        public int? UnidadMedidaid { get; set; }

        public int? TipoPresentacionid { get; set; }

        public bool? Activo { get; set; }
    }
}
