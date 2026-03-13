using System.ComponentModel.DataAnnotations;

namespace SistemaDeHorarios.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string NivelEducativo { get; set; }

    }
}
