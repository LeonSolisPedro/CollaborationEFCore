using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollaborationEFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    PetName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    PetType = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    OwnerName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
