﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Xianer_SkiClub.Data;

namespace Xianer_SkiClub.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190403020116_a")]
    partial class a
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Appointment", b =>
                {
                    b.Property<int>("appointmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("appointment_UserappointmentUserId");

                    b.Property<int?>("coachId");

                    b.Property<int?>("scheduleAppointmentId");

                    b.Property<int>("scheduleId");

                    b.HasKey("appointmentId");

                    b.HasIndex("appointment_UserappointmentUserId");

                    b.HasIndex("coachId");

                    b.HasIndex("scheduleAppointmentId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.AppointmentUser", b =>
                {
                    b.Property<int>("appointmentUserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("appointmentId");

                    b.Property<int>("userId");

                    b.HasKey("appointmentUserId");

                    b.ToTable("AppointmentUser");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Coach", b =>
                {
                    b.Property<int>("coachId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("coachId");

                    b.ToTable("Coach");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Group", b =>
                {
                    b.Property<int>("groupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("createBy");

                    b.Property<DateTime>("createdAt");

                    b.Property<int?>("group_UsergroupUserId");

                    b.HasKey("groupId");

                    b.HasIndex("group_UsergroupUserId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.GroupUser", b =>
                {
                    b.Property<int>("groupUserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("groupId");

                    b.Property<int>("userId");

                    b.HasKey("groupUserId");

                    b.ToTable("GroupUser");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Location", b =>
                {
                    b.Property<int>("locationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("locationDesc");

                    b.HasKey("locationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Member", b =>
                {
                    b.Property<int>("memberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("membershipId");

                    b.HasKey("memberId");

                    b.HasIndex("membershipId")
                        .IsUnique();

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Membership", b =>
                {
                    b.Property<int>("membershipId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("endDate");

                    b.Property<bool>("membershipState");

                    b.Property<DateTime>("startDate");

                    b.HasKey("membershipId");

                    b.ToTable("Memebership");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Schedule", b =>
                {
                    b.Property<int>("scheduleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("coachId");

                    b.Property<int>("createByEmployeeId");

                    b.Property<DateTime>("createDate");

                    b.Property<DateTime>("endDate");

                    b.Property<int>("lastModifiedByEmployeeId");

                    b.Property<DateTime>("lastModifiedDate");

                    b.Property<int>("locationId");

                    b.Property<int?>("schedule_AppointmentscheduleAppointmentId");

                    b.Property<int>("schedule_CoachId");

                    b.Property<DateTime>("startDate");

                    b.HasKey("scheduleId");

                    b.HasIndex("coachId");

                    b.HasIndex("locationId");

                    b.HasIndex("schedule_AppointmentscheduleAppointmentId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.ScheduleAppointment", b =>
                {
                    b.Property<int>("scheduleAppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("appointmentId");

                    b.Property<int>("scheduleId");

                    b.HasKey("scheduleAppointmentId");

                    b.ToTable("ScheduleAppointment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Appointment", b =>
                {
                    b.HasOne("Xianer_SkiClub.Models.AppointmentUser", "appointment_User")
                        .WithMany("appointment")
                        .HasForeignKey("appointment_UserappointmentUserId");

                    b.HasOne("Xianer_SkiClub.Models.Coach")
                        .WithMany("appointments")
                        .HasForeignKey("coachId");

                    b.HasOne("Xianer_SkiClub.Models.ScheduleAppointment")
                        .WithMany("appointment")
                        .HasForeignKey("scheduleAppointmentId");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Group", b =>
                {
                    b.HasOne("Xianer_SkiClub.Models.GroupUser", "group_User")
                        .WithMany("group")
                        .HasForeignKey("group_UsergroupUserId");
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Member", b =>
                {
                    b.HasOne("Xianer_SkiClub.Models.Membership", "membership")
                        .WithOne("member")
                        .HasForeignKey("Xianer_SkiClub.Models.Member", "membershipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Xianer_SkiClub.Models.Schedule", b =>
                {
                    b.HasOne("Xianer_SkiClub.Models.Coach", "coach")
                        .WithMany("schedules")
                        .HasForeignKey("coachId");

                    b.HasOne("Xianer_SkiClub.Models.Location", "location")
                        .WithMany("schedules")
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Xianer_SkiClub.Models.ScheduleAppointment", "schedule_Appointment")
                        .WithMany("schedule")
                        .HasForeignKey("schedule_AppointmentscheduleAppointmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
