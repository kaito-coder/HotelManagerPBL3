using PBL3.Model;
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
using Aspose.Words;
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;

namespace PBL3.View
{
    public partial class AddBillForm : Form
    {
        private string _IdReservation;
       

        public string IdReservation { get => _IdReservation; set => _IdReservation = value; }
        public AddBillForm()
        {
            InitializeComponent();
        }

        private void Gui()
        { Bill objBill = null;
            List<Bill> data = Common.Intance.Bills.ToList();
            foreach (Bill bill in data)
            {
                if (bill.ID_Reservation == _IdReservation)
                {
                    objBill = bill;
                    break;
                }
            }

            idReservationtextBox.Text = _IdReservation;
            Reservation objReservation = Common.Intance.Reservations.Find(_IdReservation);
            nameCustomertextBox.Text = objReservation.Customer.NameCustomer;
            idRoomtextBox.Text = objReservation.ID_Room;
            datePayDateTimePicker1.Value = objReservation.CheckIn;
            checkinDTP.Value = objReservation.CheckIn;
            checkoutDTP.Value = objReservation.CheckOut;
            priceLable.Text = objReservation.Room.TypeRoom.PriceTypeRoom.ToString();
            totalTextBox.Text =TotalPay(_IdReservation).ToString();
            var query = Common.Intance.Reservations.Where(c => c.ID_Reservation == _IdReservation).SelectMany(c => c.Services).Select(c => new { c.ID_Service, c.NameService, c.Price });
            typeRoomTxt.Text = objReservation.Room.TypeRoom.NameTypeRoom;
            serviceOrderDTG.DataSource = query.ToList();
            if (objBill != null)
            {
                isPaidradioButton1.Checked = objBill.IsPaid;
                if (!objBill.IsPaid)
                {
                    unpaidRadiobutton.Checked = true;
                }
                paymentMethodcomboBox.SelectedItem = objBill.PaymentMethod;

            }

        }
        public double TotalPay(string idReservation)

        {
            Reservation rs = Common.Intance.Reservations.Find(idReservation);
            double total = 0;
            TimeSpan time = rs.CheckOut - rs.CheckIn;
            double moneyRoom = Convert.ToDouble(time.Days) * rs.Room.TypeRoom.PriceTypeRoom;
            double moneyService = 0;
            foreach (Service i in rs.Services)
            {
                moneyService += i.Price;
            }
            total = moneyService + moneyRoom;
            return total;


        }

        private void AddBillForm_Load(object sender, EventArgs e)
        {
            Gui();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            bool isInsert = true;
            Bill objBill = null;
            List<Bill> data = Common.Intance.Bills.ToList();
            foreach(Bill bill in data)
            {
                if(bill.ID_Reservation == _IdReservation)
                {
                    objBill = bill;
                    break;
                }
            }
            if(objBill != null)
            {
                isInsert = false;
            }
            else
            {
                objBill=new Bill();
            }
            objBill.ID_Reservation = _IdReservation;
            objBill.DatePay = datePayDateTimePicker1.Value;
            objBill.IsPaid = isPaidradioButton1.Checked;
            objBill.Total = Convert.ToDouble(totalTextBox.Text.ToString());
            objBill.PaymentMethod = paymentMethodcomboBox.SelectedItem.ToString();
            if (isInsert)
            {
                Common.Intance.Bills.Add(objBill);
            }
            Common.Intance.SaveChanges();
            this.Close();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Document Bill = new Document("C:\\Users\\kaito\\Documents\\PBL3\\PBL3\\PBL3\\Template\\BillPrint.doc");
            Bill.MailMerge.Execute(new[] { "NAMECUSTOMER" }, new[] {nameCustomertextBox.Text.ToString()});
            Bill.MailMerge.Execute(new[] { "room" }, new[] { idRoomtextBox.Text.ToString() });
            Bill.MailMerge.Execute(new[] { "typeRoom" }, new[] { typeRoomTxt.Text.ToString() });

            Bill.MailMerge.Execute(new[] { "priceRoom" }, new[] { priceLable.Text.ToString() });
            Bill.MailMerge.Execute(new[] { "checkin" }, new[] { checkinDTP.Value.ToString("dd/MM/yyyy") });
            Bill.MailMerge.Execute(new[] { "checkout" }, new[] { checkoutDTP.Value.ToString("dd/MM/yyyy") });

            Bill.MailMerge.Execute(new[] { "total" }, new[] { totalTextBox.Text.ToString() });
            Bill.MailMerge.Execute(new[] { "datepay" }, new[] { datePayDateTimePicker1.Value.ToString("dd/MM/yyyy") });
            Bill.MailMerge.Execute(new[] { "paymentmethod" }, new[] { paymentMethodcomboBox.SelectedItem.ToString() });

            Table serviceOrder = Bill.GetChild(NodeType.Table, 0, true) as Table;
            int RowCount = serviceOrderDTG.Rows.Count;
            int rowCurrent = 1;
            serviceOrder.InsertRows(rowCurrent, rowCurrent, RowCount - 1);
            for (int i = 1; i <= RowCount; i++)
            {
                serviceOrder.PutValue(rowCurrent, 0, serviceOrderDTG.Rows[i-1].Cells[0].Value.ToString());
                serviceOrder.PutValue(rowCurrent, 1, serviceOrderDTG.Rows[i-1].Cells[1].Value.ToString());
                serviceOrder.PutValue(rowCurrent, 2, serviceOrderDTG.Rows[i-1].Cells[2].Value.ToString());
                
                rowCurrent++;
            }


            Bill.SaveAndOpenFile("BillPrint.doc");
        }

        
    }
}
