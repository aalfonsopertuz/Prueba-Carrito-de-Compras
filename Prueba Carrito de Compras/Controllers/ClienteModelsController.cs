using Microsoft.AspNetCore.Mvc;
using Prueba_Tecnica_Carrito_de_Compra.Datos;
using Prueba_Tecnica_Carrito_de_Compra.Models;

namespace Prueba_Carrito_de_Compras.Controllers
{
    public class ClienteModelsController : Controller
    {
        private readonly AppDbContext _context;

        public ClienteModelsController(AppDbContext context)
        {
            _context = context;
        }
      
        public IActionResult Index()    
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult ConsultUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClienteModel clienteModel)
        {       
            _context.Add(clienteModel);
            _context.SaveChanges();
            return RedirectToAction();  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConsultUser(ClienteModel clogin)
        {
            var user = _context.Clientes.Where(c => c.Correo.Equals(clogin.Correo)
            && c.Password.Equals(clogin.Password)).FirstOrDefault();
            return View(user);
        }

        


    }
}
