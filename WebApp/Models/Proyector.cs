using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Proyector
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "La marca es requerida")]
        [StringLength(24)]
        public string Marca { get; set; }
        
        [Required(ErrorMessage = "El modelo es requerido")]
        public string Modelo { get; set; }
        
        [Required(ErrorMessage ="El número de serie es requerido")]
        public string NumeroDeSerie { get; set; }
        public SituacionProyector Situacion { get; set; } = SituacionProyector.Bueno;
        
        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime? FechaDeBaja { get; set; } = null;

    }

    public enum SituacionProyector
    {
        Bueno = 1,
        Regular = 2,
        Malo = 3
    } 
}

