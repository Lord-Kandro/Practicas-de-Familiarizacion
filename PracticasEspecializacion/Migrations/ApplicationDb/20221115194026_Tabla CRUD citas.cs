using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticasEspecializacion.Migrations.ApplicationDb
{
    public partial class TablaCRUDcitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agendas",
                columns: table => new
                {
                    IdAgenda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paciente = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    observacion = table.Column<string>(nullable: true),
                    ApplicationUsersId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agendas", x => x.IdAgenda);
                    table.ForeignKey(
                        name: "FK_agendas_ApplicationUser_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_agendas_ApplicationUsersId",
                table: "agendas",
                column: "ApplicationUsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "agendas");
        }
    }
}
