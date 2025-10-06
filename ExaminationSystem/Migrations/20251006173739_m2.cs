using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamAttempt_User_StudentId",
                table: "ExamAttempt");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamAttempt_User_StudentId",
                table: "ExamAttempt",
                column: "StudentId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamAttempt_User_StudentId",
                table: "ExamAttempt");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamAttempt_User_StudentId",
                table: "ExamAttempt",
                column: "StudentId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
