using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuLibrary.Models
{
   public class PersonMemberEmployeeModel
    {
        public List<List<RestaurantMemberModel>> ResMember { get; set; } = new List<List<RestaurantMemberModel>>();
        public List<List<RestaurantEmployeeModel>> ResEmployee { get; set; } = new List<List<RestaurantEmployeeModel>>();
    }
}
