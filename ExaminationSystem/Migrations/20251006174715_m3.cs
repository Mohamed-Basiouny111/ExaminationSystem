using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExamId1",
                table: "ExamAttempt",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExamAttempt_ExamId1",
                table: "ExamAttempt",
                column: "ExamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamAttempt_Exam_ExamId1",
                table: "ExamAttempt",
                column: "ExamId1",
                principalTable: "Exam",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamAttempt_Exam_ExamId1",
                table: "ExamAttempt");

            migrationBuilder.DropIndex(
                name: "IX_ExamAttempt_ExamId1",
                table: "ExamAttempt");

            migrationBuilder.DropColumn(
                name: "ExamId1",
                table: "ExamAttempt");
        }
    }
}
