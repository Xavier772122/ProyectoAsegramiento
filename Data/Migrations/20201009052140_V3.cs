using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.Data.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pnc_modelo",
                columns: table => new
                {
                    Idpnc = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fecha_registro = table.Column<DateTime>(nullable: false),
                    nombre_proceso = table.Column<string>(nullable: true),
                    producto = table.Column<string>(nullable: true),
                    accion_inmediata = table.Column<int>(nullable: false),
                    accion_correctiva = table.Column<int>(nullable: false),
                    descripcion_accion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pnc_modelo", x => x.Idpnc);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pnc_modelo");
        }
    }
}
