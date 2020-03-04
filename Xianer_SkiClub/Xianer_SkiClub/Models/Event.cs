using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class Event
    {
        public int eventId { get; set; }
        public string eventName { get; set; }
        public string eventDesc { get; set; }
        public DateTime createDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string createByEmployeeId { get; set; }
        public string lastModifiedByEmployeeId { get; set; }
        public string lastModifiedDate { get; set; }
    }
}
