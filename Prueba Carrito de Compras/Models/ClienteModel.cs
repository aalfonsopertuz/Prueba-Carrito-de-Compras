using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prueba_Tecnica_Carrito_de_Compra.Models
{
    public class ClienteModel
    {
        [Key]
        public string? IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }
        public string? Password { get; set; }


        public List<PedidoModel>? PedidiosCliente { get; set; }


    }
}
