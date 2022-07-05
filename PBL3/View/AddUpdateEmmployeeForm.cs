using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.Model;

namespace PBL3.View
{
    public partial class AddUpdateEmmployeeForm : Form
    {
        private string _IDEmployee;
        public string IDEmployee { get => _IDEmployee; set => _IDEmployee = value; }
        public AddUpdateEmmployeeForm()
        {
            InitializeComponent();
        }
        private void GUI()
        {
            Employee objEmployee = Common.Intance.Employees.Find(_IDEmployee);
            if(objEmployee != null)
            {
                idEmployeetextBox.Text = objEmployee.ID_Employee;
                idEmployeetextBox.Enabled = false;
                nameEmployeetextBox.Text = objEmployee.NameEmployee;
                maleButton.Checked = Convert.ToBoolean(objEmployee.Gender.ToString());
                dateOfBirthDTP.Value = Convert.ToDateTime(objEmployee.DateOfBirth);
                phonetextBox.Text = objEmployee.Phone;
                cccdtextBox.Text = objEmployee.CCCD;
                addresstextBox5.Text = objEmployee.Address;
                salarytextBox.Text = objEmployee.Salary.ToString();
                dateIndateTimePicker.Value = objEmployee.Date_In;
                if(objEmployee.Role == "Admin")
                {
                    rolecomboBox.SelectedIndex = 0;
                }
                else
                {
                    rolecomboBox.SelectedIndex = 1;

                }
                userNametextBox.Text = objEmployee.Account.UserName;
                passWordtextBox.Text = objEmployee.Account.Password;
            }
        }
        private void okbutton_Click(object sender, EventArgs e)
        {
            bool IsInsert = true;
            Employee objEmployee = null;
            Account account = null;
            if (!string.IsNullOrEmpty(_IDEmployee))
            {
                objEmployee = Common.Intance.Employees.Find(IDEmployee);
            }
            if (objEmployee != null)
            {
                IsInsert = false;
                account = objEmployee.Account;
            }
            else
            {
                objEmployee = new Employee();
                account = new Account();
                

            }
            objEmployee.ID_Employee = idEmployeetextBox.Text.ToString();
            objEmployee.NameEmployee = nameEmployeetextBox.Text.ToString();
            objEmployee.Gender = maleButton.Checked;
            objEmployee.DateOfBirth = dateOfBirthDTP.Value;
            objEmployee.Phone = phonetextBox.Text.ToString();
            objEmployee.CCCD = cccdtextBox.Text.ToString();
            objEmployee.Address = addresstextBox5.Text.ToString();
            objEmployee.Date_In = dateIndateTimePicker.Value;
            objEmployee.Salary = Convert.ToDouble(salarytextBox.Text.ToString());
            objEmployee.Role = rolecomboBox.SelectedItem.ToString();
                account.UserName = userNametextBox.Text.ToString();
                account.Password = passWordtextBox.Text.ToString();




            if (IsInsert)
            {
                Common.Intance.Employees.Add(objEmployee);
               
                account.ID_Employee = objEmployee.ID_Employee;
                account.UserName = userNametextBox.Text.ToString();
                account.Password = passWordtextBox.Text.ToString(); 
                Common.Intance.Accounts.Add(account);
            }
            Common.Intance.SaveChanges();
            this.Close();

        }

        private void cancelbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUpdateEmmployeeForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_IDEmployee))
            {
                GUI();
            }
        }
    }
}
