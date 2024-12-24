using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planificador.Backend.Migrations
{
    /// <inheritdoc />
    public partial class RenameNameToActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Actividades",
                newName: "Activity");

            migrationBuilder.RenameIndex(
                name: "IX_Actividades_Name",
                table: "Actividades",
                newName: "IX_Actividades_Activity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Activity",
                table: "Actividades",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Actividades_Activity",
                table: "Actividades",
                newName: "IX_Actividades_Name");
        }
    }
}
