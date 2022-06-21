using System.ComponentModel.DataAnnotations;

namespace Prueba_Tecnica_Carrito_de_Compra.Models
{
    public class ProductoModel
    {
        [Key]
        public string? CodigoProducto { get; set; }
        public string? Nombre { get; set; }
    }
}
