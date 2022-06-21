﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_Tecnica_Carrito_de_Compra.Datos;

#nullable disable

namespace Prueba_Carrito_de_Compras.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220616162300_Primera")]
    partial class Primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Prueba_Tecnica_Carrito_de_Compra.Models.ClienteModel", b =>
                {
                    b.Property<string>("IdCliente")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Prueba_Tecnica_Carrito_de_Compra.Models.PedidoModel", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"), 1L, 1);

                    b.Property<string>("IdClientePedido")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("TotalPago")
                        .HasColumnType("float");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdClientePedido");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Prueba_Tecnica_Carrito_de_Compra.Models.ProductoDisponibleModel", b =>
                {
                    b.Property<string>("CodigoProducto")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Descuento")
                        .HasColumnType("bit");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioCompra")
                        .HasColumnType("float");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.Property<int>("UnidadesDisponibles")
                        .HasColumnType("int");

                    b.HasKey("CodigoProducto");

                    b.ToTable("ProductosDisponibles");
                });

            modelBuilder.Entity("Prueba_Tecnica_Carrito_de_Compra.Models.ProductoPedidoModel", b =>
                {
                    b.Property<string>("CodigoProducto")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdPedidoProducto")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioCompra")
                        .HasColumnType("float");

                    b.Property<int>("UnidadesCompradas")
                        .HasColumnType("int");

                    b.HasKey("CodigoProducto");

                    b.HasIndex("IdPedidoProducto");

                    b.ToTable("ProductosPedidos");
                });

            modelBuilder.Entity("Prueba_Tecnica_Carrito_de_Compra.Models.PedidoModel", b =>
                {
                    b.HasOne("Prueba_Tecnica_Carrito_de_Compra.Models.ClienteModel", "ClientePedido")
                        .WithMany("PedidiosCliente")
                        .HasForeignKey("IdClientePedido");

                    b.Navigation("ClientePedido");
                });

            modelBuilder.Entity("Prueba_Tecnica_Carrito_de_Compra.Models.ProductoPedidoModel", b =>
                {
                    b.HasOne("Prueba_Tecnica_Carrito_de_Compra.Models.PedidoModel", "PedidoProducto")
                        .WithMany("ProductosPedido")
                        .HasForeignKey("IdPedidoProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PedidoProducto");
                });

            modelBuilder.Entity("Prueba_Tecnica_Carrito_de_Compra.Models.ClienteModel", b =>
                {
                    b.Navigation("PedidiosCliente");
                });

            modelBuilder.Entity("Prueba_Tecnica_Carrito_de_Compra.Models.PedidoModel", b =>
                {
                    b.Navigation("ProductosPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
