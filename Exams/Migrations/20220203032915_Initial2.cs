using Microsoft.EntityFrameworkCore.Migrations;

namespace Exams.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Category_CategoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "QuestionsId",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_QuestionsId",
                table: "Category",
                column: "QuestionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Questions_QuestionsId",
                table: "Category",
                column: "QuestionsId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Questions_QuestionsId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_QuestionsId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "QuestionsId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Category_CategoryId",
                table: "Questions",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
