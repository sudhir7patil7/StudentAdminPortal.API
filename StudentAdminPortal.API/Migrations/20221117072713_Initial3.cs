using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdminPortal.API.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProgielImageUrl",
                table: "student",
                newName: "ProfileImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileImageUrl",
                table: "student",
                newName: "ProgielImageUrl");
        }
    }
}
