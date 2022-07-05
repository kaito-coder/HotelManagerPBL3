using PBL3.DTO;
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
    public partial class DashboardForm : Form
    {
        private Dashboard model;
        private Button currenButton;
        public DashboardForm()
        {
            InitializeComponent();
            //Default - Last 7 days
            startDateDateTimePicker.Value = DateTime.Today.AddDays(-7);
            endDateDTP.Value = DateTime.Now;
            last7DaysButton.Select();
            model = new Dashboard();
            LoadData();
        }
        private void LoadData()
        {
            var refreshData = model.LoadData(startDateDateTimePicker.Value, endDateDTP.Value);
            if (refreshData == true)
            {
                numberOfReservationlabel.Text = model.NumReservations.ToString();
                totalRevenuelabel.Text = "$" + model.TotalRevenue.ToString();
                totalProfitlable.Text = "$" + model.TotalProfit.ToString();
                numberOfemployeeLable.Text = model.NumEmployees.ToString();
                numberOfRoomLable.Text = model.NumRooms.ToString();
                numberOfServiceLable.Text = model.NumServices.ToString();
                grossRevenuechart.DataSource = model.GrossRevenueList;
                grossRevenuechart.Series[0].XValueMember = "Date";
                grossRevenuechart.Series[0].YValueMembers = "TotalAmount";
                grossRevenuechart.DataBind();
                chartTopProducts.DataSource = model.TopTypeRoomList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();
                
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        } 

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void SetDateMenuButtonsUI(object button)
        {
            var btn = (Button)button;
            //highlight Button
            btn.BackColor = thisMonthButton.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            //unHighLight Button
            if(currenButton != null && currenButton != btn)
            {
                currenButton.BackColor = this.BackColor;
                currenButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currenButton = btn; //set current Button

            startDateDateTimePicker.Enabled = false;
            endDateDTP.Enabled = false;
            okButton.Visible = false;
        }

        private void todayButton_Click(object sender, EventArgs e)
        {
            startDateDateTimePicker.Value = DateTime.Today;
            endDateDTP.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void last7DaysButton_Click(object sender, EventArgs e)
        {
            startDateDateTimePicker.Value = DateTime.Today.AddDays(-7);
            endDateDTP.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void thisMonthButton_Click(object sender, EventArgs e)
        {
            startDateDateTimePicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            endDateDTP.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            startDateDateTimePicker.Enabled = true;
            endDateDTP.Enabled = true;
            okButton.Visible = true;
        }   
    }
}
