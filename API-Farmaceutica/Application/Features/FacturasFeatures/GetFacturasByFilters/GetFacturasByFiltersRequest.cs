namespace API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters
{
    public record GetFacturasByFiltersRequest
    {
        public int? FacturaID { get; init; } 
        public DateTime? FechaInicio { get; init; } = DateTime.MinValue;
        public DateTime? FechaFin { get; init; } = DateTime.MaxValue;
        public int? EmpleadoID { get; init; }
        public int? SucursalID { get; init; } 
        public int? MetodoPagoID { get; init; } 
    }
}
