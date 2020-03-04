using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xianer_SkiClub.Models
{
    public class Group
    {
        public int groupId { get; set; }        
        //userId
        public int createBy { get; set; }
        public DateTime createdAt { get; set; }
        public GroupUser group_User { get; set; }
    }
}
