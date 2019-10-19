using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantKuLibrary.Models;

namespace RestaurantKuLibrary.DataAccess.TextHelper
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)//EmployeeDataModels.csv
        {
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
        }
        public static List<string>LoadFile(this string file)
        {
            if (!File.Exists(file)==false)
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<RestaurantEmployeeModel> ConvertToEmployeeModels(this List<string> lines)
        {
            List<RestaurantEmployeeModel> output = new List<RestaurantEmployeeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                RestaurantEmployeeModel e = new RestaurantEmployeeModel();
                e.EmployeeId = cols[0];
                e.EmployeeName = cols[1];
                e.EmployeeEmail = cols[2];
                e.EmployeePassword = cols[3];
                e.EmployeeHandPhoneNumber = cols[4];
                e.EmployeePosition = cols[5];
                output.Add(e);
            }
            return output;
        }
    }
}
