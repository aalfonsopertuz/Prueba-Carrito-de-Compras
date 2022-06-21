using Microsoft.EntityFrameworkCore;
using Prueba_Tecnica_Carrito_de_Compra.Models;

namespace Prueba_Tecnica_Carrito_de_Compra.Datos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteModel>()
                .HasMany<PedidoModel>(C => C.PedidiosCliente)
                .WithOne(P => P.ClientePedido)
                .HasForeignKey(p => p.IdClientePedido);

            modelBuilder.Entity<PedidoModel>()
                .HasMany<ProductoPedidoModel>(Pe => Pe.ProductosPedido)
                .WithOne(Pr => Pr.PedidoProducto)
                .HasForeignKey(Pr => Pr.IdPedidoProducto);
        }


        public DbSet<ProductoDisponibleModel> ProductosDisponibles { get; set; }
        public DbSet<ProductoPedidoModel> ProductosPedidos { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<PedidoModel> Pedidos { get; set; }
    }
}
