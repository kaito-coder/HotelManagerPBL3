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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }
        

        private void BillForm_Load(object sender, EventArgs e)
        {
            ShowBills();
        }
        private void ShowBills()
        {
            IQueryable<Bill> data = Common.Intance.Bills;
            string id_Reservation = idReservationTxt.Text.Trim().ToString();
            if(id_Reservation != "")
            {
                data = data.Where(p => p.ID_Reservation.Contains(id_Reservation));
            }
            
            if(isPaidCheckBox1.Checked == true)
            {
                data = data.Where(p => p.IsPaid == true);
            }
            if(unPaidCheckbox.Checked == true)
            {

                data = data.Where(p => p.IsPaid == false);
            }

            var bills = data.Select(p => new { p.ID_Bill, p.ID_Reservation, p.Total, p.DatePay, p.IsPaid,p.PaymentMethod });
            billDTG.DataSource = bills.ToList();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowBills();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (billDTG.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < billDTG.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = billDTG.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < billDTG.Rows.Count; i++)
                {
                    for (int j = 0; j < billDTG.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = billDTG.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true; 
            }
        }
        
        
    }
}
