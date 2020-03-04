using Microsoft.EntityFrameworkCore.Migrations;

namespace Xianer_SkiClub.Data.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "applicationUserId",
                table: "Appointment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "applicationUserName",
                table: "Appointment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "applicationUserId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "applicationUserName",
                table: "Appointment");
        }
    }
}
