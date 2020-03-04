using Microsoft.EntityFrameworkCore.Migrations;

namespace Xianer_SkiClub.Data.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "userId",
                table: "AppointmentUser");

            migrationBuilder.AddColumn<int>(
                name: "appointmentUserId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "applicationUserId",
                table: "AppointmentUser",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_appointmentUserId",
                table: "AspNetUsers",
                column: "appointmentUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AppointmentUser_appointmentUserId",
                table: "AspNetUsers",
                column: "appointmentUserId",
                principalTable: "AppointmentUser",
                principalColumn: "appointmentUserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AppointmentUser_appointmentUserId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_appointmentUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "appointmentUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "applicationUserId",
                table: "AppointmentUser");

            migrationBuilder.AddColumn<int>(
                name: "appointmentUserId",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "AppointmentUser",
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
    }
}
