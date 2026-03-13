using System.ComponentModel.DataAnnotations;

namespace SistemaDeHorarios.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public int IdDocente { get; set; }
        public int IdAsignatura { get; set; }
        public int IdAula { get; set; }
        public int IdGrupo { get; set; }
        public string DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }

    }
}
