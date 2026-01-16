namespace API_Farmaceutica.Application.Features.ProductosFeatures.GetProductos
{
    public record GetProductosResponse
    {
        public int Productoid { get; init; }

        public string? CodigoBarraProductoid { get; init; }

        public string? NombreProducto { get; init; }

        public decimal? PrecioProducto { get; init; }

        public int? TipoSuministroid { get; init; }

        public int? ClasificacionSuministroid { get; init; }

        public int? UnidadMedidaid { get; init; }

        public int? TipoPresentacionid { get; init; }

        public bool? Activo { get; init; }
    }
}
