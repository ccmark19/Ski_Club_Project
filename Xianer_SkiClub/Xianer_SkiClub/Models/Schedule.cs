using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class Schedule
    {
        public int scheduleId { get; set; }
        public int schedule_CoachId { get; set; }
        //coach object
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime createDate { get; set; }
        public string createByEmployeeId { get; set; }
        //Employee
        public DateTime lastModifiedDate { get; set; }
        public string lastModifiedByEmployeeId { get; set; }
        //Employee
        public int locationId { get; set; }
        public Location location { get; set; }
        public Coach coach { get; set; }
        public ScheduleAppointment schedule_Appointment { get; set; }
    }
}
