using WebApp.Models;

namespace WebApp.Services
{
    public interface IProyectoresService
    {
        IEnumerable<Proyector> GetAll();
        void AddProyector(Proyector proyector);
        
        //void EditProyector(int Id, Proyector proyector);
        //void DeleteProyector(int Id);

    }
}
