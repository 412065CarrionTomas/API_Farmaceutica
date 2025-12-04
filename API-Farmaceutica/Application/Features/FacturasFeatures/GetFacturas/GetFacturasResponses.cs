namespace API_Farmaceutica.Application.Features.FacturasFeatures
{
    public record GetFacturaResponse
    {
        public int Facturaid { get; init; }

        public DateTime FechaFacturacion { get; init; }

        public int Empleadoid { get; init; }

        public int Clienteid { get; init; }

        public int Sucursalid { get; init; }

        public int MetodoPagoid { get; init; }
        public ICollection<DetallesFacturaDTO> DetallesFacturaDTO { get; set; } = new List<DetallesFacturaDTO>();

    }

    public record DetallesFacturaDTO
    {
        public int NroDetalleid { get; init; }

        public int? Descuentoid { get; init; }

        public int? Productoid { get; init; }

        public int? Medicamentoid { get; init; }

        public int Cantidad { get; init; }

        public decimal? Precio { get; init; }

        public int? Coberturaid { get; init; }

        public int? Facturaid { get; init; }
    }
}
