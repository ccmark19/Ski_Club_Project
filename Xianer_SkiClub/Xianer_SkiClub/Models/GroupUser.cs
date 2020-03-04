using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class GroupUser
    {
        [Key]
        public int groupUserId { get; set; }
        public int groupId { get; set; }
        public int userId { get; set; }
        //public ICollection<int> userIdList { get; set; }
        public ICollection<Group> group { get; set; }
    }
}
