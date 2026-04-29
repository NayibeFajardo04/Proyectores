using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Indexe()
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

        public IActionResult Index()
        {
            var modelo = LoadData();
            return View(modelo);
        }

        private IEnumerable<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = 123456,
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 3,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = 123456,
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 4,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = 123456,
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                Id = 5,
                Marca = "Dell",
                Modelo = "Lightew",
                NumeroDeSerie = 346223,
                Situacion = SituacionProyector.Malo,
                FechaDeAlta = DateTime.Now
            });

            return proyectores;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
