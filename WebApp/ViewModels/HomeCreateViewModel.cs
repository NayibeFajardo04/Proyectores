using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class HomeCreateViewModel
    {

        [Required(ErrorMessage = "La marca es requerida")]
        [StringLength(24)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El modelo es requerido")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "El número de serie es requerido")]
        public string NumeroDeSerie { get; set; }
        public SituacionProyector Situacion { get; set; } = SituacionProyector.Bueno;
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        public DateTime? FechaDeBaja { get; set; } = null;

    }
}
