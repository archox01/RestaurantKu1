using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuLibrary.Models
{
   public class DetailOrderModel
    {
       /// <summary>
       /// Represent The Detail Id
       /// </summary>
        public int OrderDetailId{ get; set; }
        /// <summary>
        /// Represent The Order Id
        /// </summary>
        public HeaderOrderModel ResHeaderOrder { get; set; }
        /// <summary>
        /// Represent The Menu Id
        /// </summary>
        public RestaurantMenuModel ResMenu { get; set; }
        /// <summary>
        /// Represent The Quantity Of The Food Ordered
        /// </summary>
        public int QuantityOrder { get; set; }
        /// <summary>
        /// Represent The Price Of the FOod
        /// </summary>
        public double PriceOrder { get; set; }
        /// <summary>
        /// Represent The Food Status : Cooked , Standby , Done
        /// </summary>
        public string FoodStatus { get; set; }
        

    }
}
