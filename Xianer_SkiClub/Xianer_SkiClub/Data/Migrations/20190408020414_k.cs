using Microsoft.EntityFrameworkCore.Migrations;

namespace Xianer_SkiClub.Data.Migrations
{
    public partial class k : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "appointmentUserId",
                table: "Member",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_appointmentUserId",
                table: "Member",
                column: "appointmentUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_AppointmentUser_appointmentUserId",
                table: "Member",
                column: "appointmentUserId",
                principalTable: "AppointmentUser",
                principalColumn: "appointmentUserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_AppointmentUser_appointmentUserId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_appointmentUserId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "appointmentUserId",
                table: "Member");
        }
    }
}
