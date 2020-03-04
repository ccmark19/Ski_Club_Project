using Microsoft.EntityFrameworkCore.Migrations;

namespace Xianer_SkiClub.Data.Migrations
{
    public partial class u : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Coach_coachId",
                table: "Schedule");

            migrationBuilder.AlterColumn<int>(
                name: "coachId",
                table: "Schedule",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "schedule_CoachId",
                table: "Schedule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Coach_coachId",
                table: "Schedule",
                column: "coachId",
                principalTable: "Coach",
                principalColumn: "coachId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Coach_coachId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "schedule_CoachId",
                table: "Schedule");

            migrationBuilder.AlterColumn<int>(
                name: "coachId",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Coach_coachId",
                table: "Schedule",
                column: "coachId",
                principalTable: "Coach",
                principalColumn: "coachId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
