using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class ScheduleAppointment
    {
        [Key]
        public int scheduleAppointmentId { get; set; }
        public int scheduleId { get; set; }
        public int appointmentId { get; set; }
        public ICollection<Appointment> appointment { get; set; }
        public ICollection<Schedule> schedule { get; set; }
    }
}
