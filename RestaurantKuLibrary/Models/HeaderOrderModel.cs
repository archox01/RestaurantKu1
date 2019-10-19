using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuLibrary.Models
{
    public class HeaderOrderModel
    {
        public RestaurantEmployeeModel  ResEmployee{ get; set; }
        public int OrderId { get; set; }
        public RestaurantMemberModel ResMember { get; set; }
        public string DateOrder { get; set; }
        public string PaymentOrder { get; set; }
        public string BankName { get; set; }
    } 
}
