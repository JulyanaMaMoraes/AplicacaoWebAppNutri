using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste.Migrations
{
    /// <inheritdoc />
    public partial class Migrations3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cadastro");

            migrationBuilder.RenameTable(
                name: "Cadastro",
                newName: "Paciente");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Paciente",
                newName: "CPF");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Caloria",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PacienteCPF",
                table: "Caloria",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Paciente",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente",
                column: "CPF");

            migrationBuilder.CreateIndex(
                name: "IX_Caloria_PacienteCPF",
                table: "Caloria",
                column: "PacienteCPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Caloria_Paciente_PacienteCPF",
                table: "Caloria",
                column: "PacienteCPF",
                principalTable: "Paciente",
                principalColumn: "CPF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caloria_Paciente_PacienteCPF",
                table: "Caloria");

            migrationBuilder.DropIndex(
                name: "IX_Caloria_PacienteCPF",
                table: "Caloria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Caloria");

            migrationBuilder.DropColumn(
                name: "PacienteCPF",
                table: "Caloria");

            migrationBuilder.RenameTable(
                name: "Paciente",
                newName: "Cadastro");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Cadastro",
                newName: "Cpf");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Cadastro",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Cadastro",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro",
                column: "Id");
        }
    }
}
