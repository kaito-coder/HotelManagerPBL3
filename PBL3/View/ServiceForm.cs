using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.View;
using PBL3.Model;

namespace PBL3.Forms
{
    public partial class ServiceForm : Form
    {
        private string _Role;

        public string Role { get => _Role; set => _Role = value; }

        public ServiceForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            ShowServices();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddUpdateServiceForm formDetail = new AddUpdateServiceForm();
            formDetail.ShowDialog();
            ShowServices();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            AddUpdateServiceForm formDetail = new AddUpdateServiceForm();
            formDetail.IDService = serviceDTG.CurrentRow.Cells["ID_Service"].Value.ToString();
            formDetail.ShowDialog();
            ShowServices();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure to delete the service ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                List<string> servicesDelete = new List<string>();
                if (serviceDTG.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in serviceDTG.SelectedRows)
                    {
                        servicesDelete.Add(i.Cells["ID_Service"].Value.ToString());
                    }
                }
                if (servicesDelete.Count > 0)
                {
                    foreach (var i in servicesDelete)
                    {
                        Service obj = Common.Intance.Services.Find(i);
                        BLLService.Instance.DeleteService(obj);
                    }
                }
            }
            ShowServices();




        }
        public void ShowServices()
        {
            string nameService = nameServiceTxt.Text.Trim().ToString();
            IQueryable<Service> lsService = Common.Intance.Services;
            if (nameService != "")
            {
                lsService = lsService.Where(p=> p.NameService.Contains(nameService));
            }
            if(pricecomboBox.SelectedIndex == 1)
            {
                lsService = from services in lsService
                            orderby services.Price descending
                            select services;

            }
            else
            {
                lsService = from services in lsService
                            orderby services.Price 
                            select services;

            }
            

            
            serviceDTG.DataSource = lsService.ToList();

        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            if(_Role == "User")
            {
                addButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            ShowServices();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ShowServices();
        }
    }
}
