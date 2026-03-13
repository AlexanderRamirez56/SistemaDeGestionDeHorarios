using System.ComponentModel.DataAnnotations;

namespace SistemaDeHorarios.Models
{
    public class Aula
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
    }
}
