using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un titulo del departamento")]
        public string Titulo { get; set; } = string.Empty;

        //Prop nav relación
        public IEnumerable<Proyector> Proyectores { get; set; } = new List<Proyector>();
    }
}
