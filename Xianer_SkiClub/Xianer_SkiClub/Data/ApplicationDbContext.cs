using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Xianer_SkiClub.Models;
using Microsoft.AspNetCore.Identity;

namespace Xianer_SkiClub.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Xianer_SkiClub.Models.Appointment> Appointment { get; set; }
        public DbSet<Xianer_SkiClub.Models.AppointmentUser> AppointmentUser { get; set; }
        public DbSet<Xianer_SkiClub.Models.GroupUser> GroupUser { get; set; }
        public DbSet<Xianer_SkiClub.Models.Group> Group { get; set; }
        public DbSet<Xianer_SkiClub.Models.Location> Location { get; set; }
        public DbSet<Xianer_SkiClub.Models.Membership> Memebership { get; set; }
        public DbSet<Xianer_SkiClub.Models.Schedule> Schedule { get; set; }
        public DbSet<Xianer_SkiClub.Models.ScheduleAppointment> ScheduleAppointment { get; set; }
        public DbSet<Xianer_SkiClub.Models.Coach> Coach { get; set; }
        public DbSet<Xianer_SkiClub.Models.Member> Member { get; set; }
        public DbSet<Xianer_SkiClub.Models.Event> Event { get; set; }
    }
}
