using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class AppointmentUser
    {
        [Key]
        public int appointmentUserId { get; set; }
        public string applicationUserId { get; set; }
        public int appointmentId { get; set; }
        public ICollection<ApplicationUser> userIdList { get; set; }
        public ICollection<Appointment> appointment { get; set; }
    }
}
