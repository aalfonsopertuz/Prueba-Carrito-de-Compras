using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prueba_Tecnica_Carrito_de_Compra.Models
{
    public class PedidoModel
    {
        [Key]
        public int IdPedido { get; set; }
        public double TotalPago { get; set; }

        public string? IdClientePedido { get; set; }
        public ClienteModel? ClientePedido { get; set; }
        public List<ProductoPedidoModel>? ProductosPedido { get; set; }


        public void CalcularTotalPago()
        {
            if (ProductosPedido != null)
            {
                foreach (var producto in ProductosPedido)
                {
                    this.TotalPago += (producto.UnidadesCompradas * producto.PrecioCompra);
                }
            }
        }
    }
}
