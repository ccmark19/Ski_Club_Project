using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Xianer_SkiClub.Data.Migrations
{
    public partial class y : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupUser_Group_groupId",
                table: "GroupUser");

            migrationBuilder.DropIndex(
                name: "IX_GroupUser_groupId",
                table: "GroupUser");

            migrationBuilder.AddColumn<int>(
                name: "schedule_AppointmentscheduleAppointmentId",
                table: "Schedule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "group_UsergroupUserId",
                table: "Group",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "appointment_UserappointmentUserId",
                table: "Appointment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "coachId",
                table: "Appointment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "scheduleAppointmentId",
                table: "Appointment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    coachId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.coachId);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    memberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    membershipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.memberId);
                    table.ForeignKey(
                        name: "FK_Member_Memebership_membershipId",
                        column: x => x.membershipId,
                        principalTable: "Memebership",
                        principalColumn: "membershipId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_coachId",
                table: "Schedule",
                column: "coachId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_locationId",
                table: "Schedule",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_schedule_AppointmentscheduleAppointmentId",
                table: "Schedule",
                column: "schedule_AppointmentscheduleAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_group_UsergroupUserId",
                table: "Group",
                column: "group_UsergroupUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_appointment_UserappointmentUserId",
                table: "Appointment",
                column: "appointment_UserappointmentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_coachId",
                table: "Appointment",
                column: "coachId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_scheduleAppointmentId",
                table: "Appointment",
                column: "scheduleAppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_membershipId",
                table: "Member",
                column: "membershipId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AppointmentUser_appointment_UserappointmentUserId",
                table: "Appointment",
                column: "appointment_UserappointmentUserId",
                principalTable: "AppointmentUser",
                principalColumn: "appointmentUserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Coach_coachId",
                table: "Appointment",
                column: "coachId",
                principalTable: "Coach",
                principalColumn: "coachId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_ScheduleAppointment_scheduleAppointmentId",
                table: "Appointment",
                column: "scheduleAppointmentId",
                principalTable: "ScheduleAppointment",
                principalColumn: "scheduleAppointmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_GroupUser_group_UsergroupUserId",
                table: "Group",
                column: "group_UsergroupUserId",
                principalTable: "GroupUser",
                principalColumn: "groupUserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Coach_coachId",
                table: "Schedule",
                column: "coachId",
                principalTable: "Coach",
                principalColumn: "coachId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Location_locationId",
                table: "Schedule",
                column: "locationId",
                principalTable: "Location",
                principalColumn: "locationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_ScheduleAppointment_schedule_AppointmentscheduleAppointmentId",
                table: "Schedule",
                column: "schedule_AppointmentscheduleAppointmentId",
                principalTable: "ScheduleAppointment",
                principalColumn: "scheduleAppointmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AppointmentUser_appointment_UserappointmentUserId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Coach_coachId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_ScheduleAppointment_scheduleAppointmentId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Group_GroupUser_group_UsergroupUserId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Coach_coachId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Location_locationId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_ScheduleAppointment_schedule_AppointmentscheduleAppointmentId",
                table: "Schedule");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_coachId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_locationId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_schedule_AppointmentscheduleAppointmentId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Group_group_UsergroupUserId",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_appointment_UserappointmentUserId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_coachId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_scheduleAppointmentId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "schedule_AppointmentscheduleAppointmentId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "group_UsergroupUserId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "appointment_UserappointmentUserId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "coachId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "scheduleAppointmentId",
                table: "Appointment");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUser_groupId",
                table: "GroupUser",
                column: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupUser_Group_groupId",
                table: "GroupUser",
                column: "groupId",
                principalTable: "Group",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
