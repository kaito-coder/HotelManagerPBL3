using PBL3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class AddUpdateServiceForm : Form
    {
        private string _IDService = null;
        public string IDService { get => _IDService; set => _IDService = value; }
        public AddUpdateServiceForm()
        {
            InitializeComponent();
        }

        
        private void GUI()
        {
            Service objService = Common.Intance.Services.Find(_IDService);    
            if(objService != null)
            {
                IDServicetextBox.Text = objService.ID_Service.ToString();
                IDServicetextBox.Enabled = false;
                nameServicetextBox.Text = objService.NameService.ToString();
                priceTextBox.Text = objService.Price.ToString();
            }
        }
        private void AddUpdateServiceForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_IDService))
            {
                GUI();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            bool IsInsert = true;
            Service objService = null;
            if (!string.IsNullOrEmpty(_IDService))
            {
                objService = Common.Intance.Services.Find(IDService);
            }
            if (objService != null)
            {
                IsInsert = false;
            }
            else
            {
                objService = new Service();

            }
            objService.ID_Service = IDServicetextBox.Text.ToString();
            objService.NameService = nameServicetextBox.Text;
            objService.Price = Convert.ToDouble(priceTextBox.Text.ToString());
            ;
            if (IsInsert)
            {
                Common.Intance.Services.Add(objService);
            }
            Common.Intance.SaveChanges();
            this.Close();
        }
    }
}
