using System.Collections.Generic;

namespace Prueba_Tecnica_Carrito_de_Compra.Models
{
    public class ProductoDisponibleModel : ProductoModel
    {
        public string? Imagen { get; set; }
        public int UnidadesDisponibles { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public bool Descuento { get; set; }
    }
}
