using RestaurantKuLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuLibrary.DataAccess
{
    public interface RKDataConnection
    {
        RestaurantEmployeeModel RestaurantEmpData(RestaurantEmployeeModel model);
        RestaurantMemberModel RestaurantMemberData(RestaurantMemberModel model);

        RestaurantMenuModel RestaurantMenuData(RestaurantMenuModel model);
    }
}
