using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class Appointment
    {
        [Key]
        public int appointmentId { get; set; }
        public int scheduleId { get; set; }
        public string applicationUserName { get; set; }
        public string applicationUserId { get; set; }
        private ICollection<Member> userIdList { get; set; }
        private ICollection<Coach> coachIdList { get; set; }
        public AppointmentUser appointment_User { get; set; }
    }
}
