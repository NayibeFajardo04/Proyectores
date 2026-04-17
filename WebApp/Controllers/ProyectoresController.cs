using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        public IActionResult Index()
        {
            return Content(
                "<p>Lista de proyectores</p> ",
                "text/html"
                );
        }

        public IActionResult Details(int id)
        { 
                string html ="<h1>Nuevo proyector</h1>";
                html += $"<p>Info del proyector {id}</p>";
                return Content(html, "text/html");
        }

        public IActionResult Delete(int id)
        {
            string html = "<h1>Dar de baja</h1>";
            html += $"<p>Se dará de baja al proyector {id}</p>";
            return Content(html, "text/html");
        }
        public IActionResult Edit(int id)
        {
            string html = "<h1>Modificar Proyector</h1>";
            html += $"<p>Se modificara el proyector {id}</p>";
            return Content(html, "text/html");
        }
    }
}
