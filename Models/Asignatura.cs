using System.ComponentModel.DataAnnotations;

namespace SistemaDeHorarios.Models
{
    public class Asignatura
    {
     
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int HorasSemanales { get; set; }
    }
}
