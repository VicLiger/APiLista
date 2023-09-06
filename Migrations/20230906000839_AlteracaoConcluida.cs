using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace provaACP.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoConcluida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Concluida",
                table: "Tarefas",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Concluida",
                table: "Tarefas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
