using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoOdontoprev.Migrations.Paciente
{
    /// <inheritdoc />
    public partial class PacienteM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "table_paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    name_paciente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    idade_paciente = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    nascimento_paciente = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_paciente", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table_paciente");
        }
    }
}
