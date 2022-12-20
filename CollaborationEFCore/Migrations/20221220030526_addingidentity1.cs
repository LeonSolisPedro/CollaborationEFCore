using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollaborationEFCore.Migrations
{
    public partial class addingidentity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SuperCoolId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuperCoolId",
                table: "Pets");
        }
    }
}
