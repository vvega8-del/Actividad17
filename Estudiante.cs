using System.ComponentModel.DataAnnotations;

namespace MiProyectoBlazor.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre no debe ser vacío")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Correo no debe ser vacío")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido")]
        public string Correo { get; set; } = string.Empty;

        [Range(0, 10, ErrorMessage = "La calificación debe ser de 0 a 10")]
        public double Calificacion { get; set; } = 0;
    }
}