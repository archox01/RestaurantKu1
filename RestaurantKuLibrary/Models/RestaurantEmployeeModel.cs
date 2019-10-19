using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKuLibrary.Models
{
   public class RestaurantEmployeeModel
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeHandPhoneNumber { get; set; }
        public string EmployeePosition { get; set; }

        public RestaurantEmployeeModel()
        {
                
        }
        public RestaurantEmployeeModel(string employeeId,string employeeName,string employeeEmail,string employeePassword,string employeeHandPhoneNumber,string employeePosition)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeEmail = employeeEmail;
            EmployeePassword = employeePassword;
            EmployeeHandPhoneNumber = employeeHandPhoneNumber;
            EmployeePosition = employeePosition;
        }
    }
}
