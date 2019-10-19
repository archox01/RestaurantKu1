using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantKuLibrary;
using RestaurantKuLibrary.Models;
using RestaurantKuLibrary.DataAccess;

namespace RestaurantKuUI
{
    public partial class ManageEmployeeForm : Form
    {
        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        private void InsertChefData()
        {
            using (RestaurantDBEntities db = new RestaurantDBEntities())
            {
                RestaurantEmployeeModel EmpModel = new RestaurantEmployeeModel();
                var GetEmpData = (from b in db.msemployees where b.position == "Chef" orderby b.employeeid descending select b).FirstOrDefault();
                string GetEmployeeId = EmpModel.EmployeeId;
                string GetEmployeeName = EmployeeNameTextBox.Text;
                if (GetEmployeeId == null)
                {
                    int ChefId = 0 + 1;
                    string GetChefId = "CH" + ChefId++;

                    RestaurantEmployeeModel SendToEmployeeModel = new RestaurantEmployeeModel(
                        GetChefId,
                        EmployeeNameTextBox.Text,
                        EmployeeEmailTextBox.Text,
                        EmployeePasswordTextBox.Text,
                        EmployeeHandphoneTextBox.Text,
                        EmployeePositionValue.Text);
                    GlobalConfig.Connection.RestaurantEmpData(EmpModel);
                }
                else
                {
                    {
                        var GetData = (from b in db.msemployees  where b.position == "chef" orderby b.employeeid descending select b).First();
                        string GetChefId = EmpModel.EmployeeId;
                        string SubstringChefId = GetChefId.Substring(2, 2);
                        int ConvertAIC = Convert.ToInt32(SubstringChefId) + 1;
                        string CombineChefId = SubstringChefId + "" + ConvertAIC;

                        RestaurantEmployeeModel SendToEmployeeModel = new RestaurantEmployeeModel(
                            CombineChefId,
                            EmployeeNameTextBox.Text,
                            EmployeeEmailTextBox.Text,
                            EmployeePasswordTextBox.Text,
                            EmployeeHandphoneTextBox.Text,
                            EmployeePositionValue.Text);
                        GlobalConfig.Connection.RestaurantEmpData(EmpModel);
                    }
                    MessageBox.Show("Data Berhasil Di Input !!");
                }
            }
        }

        private void InsertCashierData()
        {
            using (RestaurantDBEntities db = new RestaurantDBEntities())    
            {
                RestaurantEmployeeModel EmpModel = new RestaurantEmployeeModel();
                var GetEmpData = (from b in db.msemployees orderby b.employeeid descending select b).FirstOrDefault();
                string GetEmployeeId = EmpModel.EmployeeId;
                if (GetEmployeeId == null)
                {
                    int CashierId = 0 + 1;
                    string GetCashierId = "CA" + CashierId++;

                    RestaurantEmployeeModel SendToEmployeeModel = new RestaurantEmployeeModel(
                        GetCashierId, 
                        EmployeeNameTextBox.Text, 
                        EmployeeEmailTextBox.Text, 
                        EmployeePasswordTextBox.Text, 
                        EmployeeHandphoneTextBox.Text, 
                        EmployeePositionValue.Text);
                    GlobalConfig.Connection.RestaurantEmpData(EmpModel);
                }
                else
                {
                    var GetData = (from b in db.msemployees
                                   where b.position == "cashier"
                                   orderby b.employeeid descending
                                   select b).First();
                    string GetlastId = EmpModel.EmployeeId;
                    string SubstringCashierId = GetData.employeeid.Substring(2, 2);
                    int ConvertAIC = Convert.ToInt32(SubstringCashierId) + 1;
                    string CombineCashierId = SubstringCashierId + "" + ConvertAIC;

                    RestaurantEmployeeModel SendToEmployeeModel = new RestaurantEmployeeModel(
                        GetlastId,
                        EmployeeNameTextBox.Text,
                        EmployeeEmailTextBox.Text,
                        EmployeePasswordTextBox.Text,
                        EmployeeHandphoneTextBox.Text,
                        EmployeePositionValue.Text);
                    GlobalConfig.Connection.RestaurantEmpData(EmpModel);
                }
                MessageBox.Show("Data Berhasil Di Input !!");
            }

        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            if(EmployeePositionValue.Text == "cashier")
            {
                this.InsertCashierData();
            }
            else if(EmployeePositionValue.Text == "chef")
            {
                this.InsertChefData();
            }
            EmployeeNameTextBox.Text = "";
            EmployeeEmailTextBox.Text = "";
            EmployeePasswordTextBox.Text = "";
            EmployeeHandphoneTextBox.Text = "";
            EmployeePositionValue.SelectedText = "";
            
        }

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            using (RestaurantDBEntities db = new RestaurantDBEntities())
            {
                
            }
        }
    }
}
