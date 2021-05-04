using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pos.Api.DataAccess.Migrations
{
    public partial class initialMigrationPOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(nullable: true),
                    DescripcionProducto = table.Column<string>(nullable: true),
                    TipoProducto = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    CategoriaProducto = table.Column<int>(nullable: false),
                    CodigoBarras = table.Column<int>(nullable: false),
                    IdImpuesto = table.Column<int>(nullable: false),
                    CantidadEnBodega = table.Column<int>(nullable: false),
                    CantidadMinima = table.Column<int>(nullable: false),
                    CantidadMaxima = table.Column<int>(nullable: false),
                    UnidadMedida = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaActualizacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IdProducto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
