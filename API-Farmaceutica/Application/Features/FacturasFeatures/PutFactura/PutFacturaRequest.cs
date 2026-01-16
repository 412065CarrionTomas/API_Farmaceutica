using API_Farmaceutica.Application.Features.FacturasFeatures.PostFactura;
using System.ComponentModel.DataAnnotations;

namespace API_Farmaceutica.Application.Features.FacturasFeatures.PutFactura
{
    public record PutFacturaRequest
    {
        public int Facturaid { get; init; }
        public DateTime? FechaFacturacion { get; init; }

        public int Empleadoid { get; init; }

        public int Clienteid { get; init; }

        public int Sucursalid { get; init; }

        public int MetodoPagoid { get; init; }
        [Required]
        public ICollection<DetallesFacturasPut> DetalleFacturaDTO { get; set; } = new List<DetallesFacturasPut>();

    }
    public record DetallesFacturasPut
    {
        public int? Descuentoid { get; init; }

        public int? Productoid { get; init; }

        public int? Medicamentoid { get; init; }

        public int Cantidad { get; init; }

        public decimal Precio { get; init; }

        public int? Coberturaid { get; init; }
    }
}
