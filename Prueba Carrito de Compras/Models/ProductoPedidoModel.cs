using System.Collections.Generic;

namespace Prueba_Tecnica_Carrito_de_Compra.Models
{
    public class ProductoPedidoModel : ProductoModel
    {
        public int UnidadesCompradas { get; set; }
        public double PrecioCompra { get; set; }

        public int IdPedidoProducto { get; set; }
        public PedidoModel? PedidoProducto { get; set; }
    }
}
