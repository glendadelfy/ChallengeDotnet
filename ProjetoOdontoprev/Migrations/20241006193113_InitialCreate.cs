using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoOdontoprev.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "table_dentista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nome_dentista = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    email_dentista = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    password_dentista = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    status_active_dentista = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    description_dentista = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_dentista", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table_dentista");
        }
    }
}
