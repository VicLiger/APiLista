using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace provaACP.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarColunaTitulo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Tarefas");
        }
    }
}
