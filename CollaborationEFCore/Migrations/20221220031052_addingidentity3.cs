using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollaborationEFCore.Migrations
{
    public partial class addingidentity3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuperCoolId",
                table: "Pets",
                newName: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pets",
                table: "Pets",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pets",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Pets",
                newName: "SuperCoolId");
        }
    }
}
