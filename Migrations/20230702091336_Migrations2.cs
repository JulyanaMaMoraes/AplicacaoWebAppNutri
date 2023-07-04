using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste.Migrations
{
    /// <inheritdoc />
    public partial class Migrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alimentacao_Habitual",
                table: "Cadastro",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Comorbidade",
                table: "Cadastro",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Cadastro",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Cadastro",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Exercicio_Habitual",
                table: "Cadastro",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Idade",
                table: "Cadastro",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Objetivo",
                table: "Cadastro",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Cadastro",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Preferencia_Alimentar",
                table: "Cadastro",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Cadastro",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "telefone",
                table: "Cadastro",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Caloria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Refeicao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Horario_Refeicao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Refeicao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Peso_Refeicao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caloria", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caloria");

            migrationBuilder.DropColumn(
                name: "Alimentacao_Habitual",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Comorbidade",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Exercicio_Habitual",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Objetivo",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Preferencia_Alimentar",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "telefone",
                table: "Cadastro");
        }
    }
}
