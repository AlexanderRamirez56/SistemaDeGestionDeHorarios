using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeHorarios.Migrations
{
    /// <inheritdoc />
    public partial class FixHorarioModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdHorario",
                table: "Horarios",
                newName: "IdAsignatura");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdAsignatura",
                table: "Horarios",
                newName: "IdHorario");
        }
    }
}
