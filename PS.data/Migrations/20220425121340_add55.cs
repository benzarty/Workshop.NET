using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.data.Migrations
{
    public partial class add55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PakagingType",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PakagingType",
                table: "Products");
        }
    }
}
