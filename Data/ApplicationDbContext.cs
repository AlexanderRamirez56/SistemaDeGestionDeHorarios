using Microsoft.EntityFrameworkCore;
using SistemaDeHorarios.Models;


namespace SistemaDeHorarios.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Horario> Horarios { get; set; }
    }
}