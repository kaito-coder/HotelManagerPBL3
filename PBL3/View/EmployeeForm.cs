using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Model;
using PBL3.View;
namespace PBL3.Forms
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showEmployee();
        }
        public void showEmployee()
        {
            string nameEmployee = nameEmployeeTxt.Text.Trim().ToString();
            IQueryable<Employee> lsEmployee = Common.Intance.Employees;
            if (nameEmployee != "")
            {
                lsEmployee = lsEmployee.Where(p => p.NameEmployee.Contains(nameEmployee));
            }
            if (salaryComboBox.SelectedIndex == 1)
            {
                lsEmployee = from employees in lsEmployee
                             orderby employees.Salary descending
                             select employees;
            }
            else
            {
                lsEmployee = from employees in lsEmployee
                             orderby employees.Salary 
                             select employees;

            }


            var data = lsEmployee.Select(p => new { p.ID_Employee, p.NameEmployee, p.Gender, p.Salary, p.Date_In, p.CCCD, p.Address, p.DateOfBirth,p.Role });
            employeeDTG.DataSource = data.ToList();

        }
    
            

        private void addButton_Click(object sender, EventArgs e)
        {
            AddUpdateEmmployeeForm DetailForm = new AddUpdateEmmployeeForm();
            DetailForm.ShowDialog();
            showEmployee();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            AddUpdateEmmployeeForm DetailForm = new AddUpdateEmmployeeForm();
            DetailForm.IDEmployee = employeeDTG.CurrentRow.Cells["ID_Employee"].Value.ToString();
            DetailForm.ShowDialog();
            showEmployee();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure to delete the Employee ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                List<string> employeeDelete = new List<string>();
                if (employeeDTG.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in employeeDTG.SelectedRows)
                    {
                        employeeDelete.Add(i.Cells["ID_Employee"].Value.ToString());
                    }
                }
                if (employeeDelete.Count > 0)
                {
                    foreach (var i in employeeDelete)
                    {
                        Employee obj = Common.Intance.Employees.Find(i);
                        Common.Intance.Employees.Remove(obj);
                        Common.Intance.SaveChanges();
                    }
                }
            }
            showEmployee();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            showEmployee();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            showEmployee();
        }
    }
}
