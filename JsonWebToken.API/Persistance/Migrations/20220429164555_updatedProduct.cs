using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JsonWebToken.API.Persistance.Migrations
{
    public partial class updatedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stcok",
                table: "Products",
                newName: "Stock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Products",
                newName: "Stcok");
        }
    }
}
