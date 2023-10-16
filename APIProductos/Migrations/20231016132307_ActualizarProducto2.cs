using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProductos.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarProducto2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2,
                column: "Nombre",
                value: "1989");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2,
                column: "Nombre",
                value: "1989 (Taylor's Version)");
        }
    }
}
