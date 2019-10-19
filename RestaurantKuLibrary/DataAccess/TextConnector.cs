using RestaurantKuLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantKuLibrary.DataAccess.TextHelper;

namespace RestaurantKuLibrary.DataAccess
{
    public class TextConnector : RKDataConnection
    {
        private const string EmployeeFile = "EmployeeDataModels.csv";
        public RestaurantEmployeeModel RestaurantEmpData(RestaurantEmployeeModel model)
        {

            List<RestaurantEmployeeModel> employee = EmployeeFile.FullFilePath().LoadFile().ConvertToEmployeeModels();
            int currentId = 1;
            RestaurantEmployeeModel e = new RestaurantEmployeeModel();
            if (employee.Count > 0)
            {
                string getid = e.EmployeeId;
                
                //currentId = employee.OrderByDescending(e => e.EmployeeId).First().EmployeeId + 1;
            }

            //Employee.Add(model);
            return model;
        }

        public RestaurantMemberModel RestaurantMemberData(RestaurantMemberModel model)
        {
            throw new NotImplementedException();
        }

        public RestaurantMenuModel RestaurantMenuData(RestaurantMenuModel model)
        {
            throw new NotImplementedException();
        }
    }
}
