using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "Aluno",
                schema: "public",
                columns: table => new
                {
                    IdAluno = table.Column<Guid>(nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Matricula = table.Column<string>(type: "varchar(10)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.IdAluno);
                });

            migrationBuilder.CreateTable(
                name: "Disciplina",
                schema: "public",
                columns: table => new
                {
                    IdDisciplina = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(60)", nullable: false),
                    CargaHoraria = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplina", x => x.IdDisciplina);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Disciplina",
                schema: "public");
        }
    }
}
