using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantKuLibrary.Models;
using System.Data;
using Dapper;

namespace RestaurantKuLibrary.DataAccess
{

    public class SqlConnector : RKDataConnection
    {
        public RestaurantEmployeeModel RestaurantEmpData(RestaurantEmployeeModel model)
        {
            using (IDbConnection koneksi = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Restaurant")))
            {
                var k = new DynamicParameters();
                k.Add("@EmployeeId", model.EmployeeId);
                k.Add("@EmployeeName", model.EmployeeName);
                k.Add("@EmployeeEmail",model.EmployeeEmail);
                k.Add("@EmployeePassword",model.EmployeePassword);
                k.Add("@EmployeeHandphone",model.EmployeeHandPhoneNumber);
                k.Add("@EmployeePosition",model.EmployeePosition);
                koneksi.Execute("dbo.spMsEmployee_Insert", k, commandType:CommandType.StoredProcedure);
                return model;
            }
        }

        public List<RestaurantEmployeeModel> GetEmp_All()
        {
            List<RestaurantEmployeeModel> GetData;
            using (IDbConnection koneksi = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Restaurant")))
            {
                GetData = koneksi.Query<RestaurantEmployeeModel>("spGetEmployeeData_All").ToList();
            }
            return GetData;
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
