using System.ComponentModel.DataAnnotations;

namespace SistemaDeHorarios.Models
{
    public class Docente
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public int HorasMaximas { get; set; }

    }
}
