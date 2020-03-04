using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class Membership
    {
        [Key]
        public int membershipId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime  endDate { get; set; }
        public bool membershipState { get; set; }
        public Member member { get; set; }
    }
}
