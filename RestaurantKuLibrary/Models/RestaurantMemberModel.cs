using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuLibrary.Models
{
   public class RestaurantMemberModel
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        
        public string MemberEmail { get; set; }
        public string MemberHandPhoneNumber { get; set; }
        public string MemberJoinDate { get; set; }


    }
}
