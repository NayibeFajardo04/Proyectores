using System.ComponentModel.DataAnnotations;
using System.Xml;
using WebApp.Models;

namespace WebApp.Validations
{
    public class NoRepetirIdValidatorAttribute : ValidationAttribute
    {
        public IList<Proyector> _proyectores;

        public NoRepetirIdValidatorAttribute(IList<Proyector> proyectores)
        {
            _proyectores = proyectores;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return null;
            }
            return ValidationResult.Success;
        }
    }
}
