using API_Farmaceutica.Application.Features.FacturasFeatures.GetFacturasByFilters;
using System.ComponentModel.DataAnnotations;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura
{
    public record PostFacturaRequest
    {
        public DateTime? FechaFacturacion { get; init; }

        public int Empleadoid { get; init; }

        public int Clienteid { get; init; }

        public int Sucursalid { get; init; }

        public int MetodoPagoid { get; init; }
        [Required]
        public ICollection<DetallesFacturasPost> DetalleFacturaDTO { get; set; } = new List<DetallesFacturasPost>();
    }

    public record DetallesFacturasPost
    {
        public int? Descuentoid { get; init; }

        public int? Productoid { get; init; }

        public int? Medicamentoid { get; init; }

        public int Cantidad { get; init; }

        public decimal Precio { get; init; }

        public int? Coberturaid { get; init; }
    }
}
