using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData / ViewBag
            //ViewData["Id"] = "1";
            //ViewData["Marca"] = "Epson";
            //ViewData["Modelo"] = "Xlight";
            //ViewData["Número de serie"] = "123456";
            //ViewData["Situación"] = "Bueno";
            //ViewData["Fecha de alta"] = DateTime.Now.ToString("d");

            //Modelo de la vista
            var proyector = new Proyector()
            {
                Id = 2,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = 123456,
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            };
          
            return View(proyector);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
