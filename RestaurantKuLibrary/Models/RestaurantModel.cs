using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuLibrary.Models
{
   public class RestaurantModel
    {
        public List<List<PersonMemberEmployeeModel>> PersonMemberModels { get; set; } = new List<List<PersonMemberEmployeeModel>>();
        public List<RestaurantMenuModel> ResMenuModel { get; set; } = new List<RestaurantMenuModel>();

        public List<HeaderOrderModel> HeaderOrderModels { get; set; } = new List<HeaderOrderModel>();
        public List<DetailOrderModel> DetailOrderMOdels { get; set; } = new List<DetailOrderModel>();

    }
}
