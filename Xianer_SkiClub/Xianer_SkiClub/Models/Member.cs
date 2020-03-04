using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class Member
    {
        [Key]
        public int memberId { get; set; }
        public int membershipId { get; set; }
        public Membership membership { get; set; }
    }
}
