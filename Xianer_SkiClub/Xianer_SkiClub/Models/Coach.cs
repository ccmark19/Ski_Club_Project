using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class Coach
    {
        [key]
        public int coachId { get; set; }
        public ICollection<Schedule> schedules { get; set; }
        public ICollection<Appointment> appointments { get; set; }
    }
}
