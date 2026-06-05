using WebApp.Models;
using WebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Services
{
    public class ProyectoresService : IProyectoresService
    {
        private readonly AppDbContext _contexto;

        public ProyectoresService(AppDbContext contexto)
        {
            this._contexto = contexto;
        }

        public void AddProyector(Proyector proyector)
        {
            if(proyector != null)
            {
                _contexto.Proyectores.Add(proyector);
                _contexto.SaveChanges();
            }
        }

        /*public  IActionResult Details (int id)
        {
            var modelo = _service.GetProyectorById(id);
            if(modelo != null)
            {
                return View(modelo);
            }
            return RedirectToAction(nameof(Index));
        }*/

        public Proyector? Delete(Proyector proyector)
        {
            if (proyector != null)
            {
                _contexto.Proyectores.Remove(proyector);
                _contexto.SaveChanges();
                return proyector;
            }
            return null;
        }

        public Proyector? GetProyectorById (int id)
        {
            return _contexto.Proyectores.FirstOrDefault<Proyector>(p => p.Id == id);
        }

        public IEnumerable<Proyector> GetAll()
        {
            return _contexto.Proyectores.ToList<Proyector>();
        }

        public void Update(Proyector proyector)
        {
            if (proyector != null)
            {
                _contexto.Proyectores.Update(proyector);
                _contexto.SaveChanges();
            }
        }
    }
}
