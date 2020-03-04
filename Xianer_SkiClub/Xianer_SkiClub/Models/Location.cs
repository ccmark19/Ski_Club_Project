using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class Location
    {
        [Key]
        public int locationId { get; set; }
        public string locationDesc { get; set; }
        public ICollection<Schedule> schedules { get; set; }
    }
}
