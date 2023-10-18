using System.ComponentModel.DataAnnotations;

namespace ElHogarLibrosBlazor.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El grado es requerido")]
        public int GradoId { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es requerido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La imagen es requerida")]
        public string Imagen { get; set; }
    }
}
