using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdminPortal.API.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_students_StudentId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_students_genders_GenderId",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genders",
                table: "genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addresses",
                table: "addresses");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "student");

            migrationBuilder.RenameTable(
                name: "genders",
                newName: "gender");

            migrationBuilder.RenameTable(
                name: "addresses",
                newName: "address");

            migrationBuilder.RenameIndex(
                name: "IX_students_GenderId",
                table: "student",
                newName: "IX_student_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_StudentId",
                table: "address",
                newName: "IX_address_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_student",
                table: "student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gender",
                table: "gender",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_address",
                table: "address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_address_student_StudentId",
                table: "address",
                column: "StudentId",
                principalTable: "student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_student_gender_GenderId",
                table: "student",
                column: "GenderId",
                principalTable: "gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_address_student_StudentId",
                table: "address");

            migrationBuilder.DropForeignKey(
                name: "FK_student_gender_GenderId",
                table: "student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_student",
                table: "student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gender",
                table: "gender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_address",
                table: "address");

            migrationBuilder.RenameTable(
                name: "student",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "gender",
                newName: "genders");

            migrationBuilder.RenameTable(
                name: "address",
                newName: "addresses");

            migrationBuilder.RenameIndex(
                name: "IX_student_GenderId",
                table: "students",
                newName: "IX_students_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_address_StudentId",
                table: "addresses",
                newName: "IX_addresses_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genders",
                table: "genders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addresses",
                table: "addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_students_StudentId",
                table: "addresses",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_genders_GenderId",
                table: "students",
                column: "GenderId",
                principalTable: "genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
