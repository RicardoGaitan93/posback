using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pos.Api.DataAccess.Migrations
{
    public partial class ExternalUserM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExternalUser",
                columns: table => new
                {
                    IdTercero = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTercero = table.Column<string>(nullable: true),
                    TipoTercero = table.Column<int>(nullable: false),
                    FechaInscripcionTercero = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    TelefonoTercero1 = table.Column<string>(nullable: true),
                    TelefonoTercero2 = table.Column<string>(nullable: true),
                    TelefonoTercero3 = table.Column<string>(nullable: true),
                    DireccionTercero1 = table.Column<string>(nullable: true),
                    DireccionTercero2 = table.Column<string>(nullable: true),
                    ObservacionTercero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalUser", x => x.IdTercero);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalUser");
        }
    }
}
