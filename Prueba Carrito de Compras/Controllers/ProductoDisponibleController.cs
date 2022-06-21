
using Microsoft.AspNetCore.Mvc;
using Prueba_Tecnica_Carrito_de_Compra.Datos;
using Prueba_Tecnica_Carrito_de_Compra.Models;
using System.Net;


namespace Prueba_Carrito_de_Compras.Controllers
{
    public class ProductoDisponibleController : Controller
    {
        private readonly AppDbContext _context;

        public ProductoDisponibleController (AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            IEnumerable<ProductoDisponibleModel> consult = _context.ProductosDisponibles;
            return View(consult);
        }

        public IActionResult Details (String id)
        {
            ProductoDisponibleModel consult = _context.ProductosDisponibles.Where(p => p.CodigoProducto == id).FirstOrDefault();
            return View(consult);
        }

        public IActionResult Download(String url, String id)
        {
            String dir = "D:\\Descargas\\Producto.jpg";
            WebClient client = new WebClient();
            client.DownloadFile(url, dir);
            client.Dispose();
            ProductoDisponibleModel consult = _context.ProductosDisponibles.Where(p => p.CodigoProducto == id).FirstOrDefault();
            return View(consult);
        }

        




    }
}
