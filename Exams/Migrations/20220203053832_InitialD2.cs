using Microsoft.EntityFrameworkCore.Migrations;

namespace Exams.Migrations
{
    public partial class InitialD2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Questions_QuestionsId",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "QuestionsId",
                table: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Category_QuestionsId",
                table: "Category",
                newName: "IX_Category_Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Questions_Categories",
                table: "Category",
                column: "Categories",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Questions_Categories",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "Categories",
                table: "Category",
                newName: "QuestionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Category_Categories",
                table: "Category",
                newName: "IX_Category_QuestionsId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Questions_QuestionsId",
                table: "Category",
                column: "QuestionsId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
