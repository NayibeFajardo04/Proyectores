using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IProyectoresService _service;
        public HomeController(IProyectoresService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var modelo = _service.GetAll();
            return View(modelo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        public IActionResult Create()
        {
            var modelo = new HomeCreateViewModel();
            modelo.FechaDeAlta = DateTime.Now;
            
            return View(modelo);
        }

        [HttpPost]
        public IActionResult Create(Proyector proyector)
        {
            _service.AddProyector(proyector);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
