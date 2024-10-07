using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoOdontoprev.Migrations.Agenda
{
    /// <inheritdoc />
    public partial class AgendaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "table_agendamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    data_agenda = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    descricao_agenda = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_agendamento", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table_agendamento");
        }
    }
}
