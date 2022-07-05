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
    public partial class OrderServiceForm : Form
    {
        public OrderServiceForm()
        {
            InitializeComponent();
        }

        private void OrderServiceForm_Load(object sender, EventArgs e)
        {
            idReservationCBB();
            showMenuService();
            showOrderService();
        }
        private void showOrderService()
        {
            string idReservation = idReservationcomboBox.SelectedValue.ToString();
            if (idReservation != null)
            {
                var query = Common.Intance.Reservations.Where(c => c.ID_Reservation == idReservation).SelectMany(c => c.Services).Select(c => new {c.ID_Service,c.NameService,c.Price});

                orderServiceDTG.DataSource = query.ToList();
            }
        }
        private void  idReservationCBB()
        {
           
            List<string> idReservations = Common.Intance.Reservations.Select(p => p.ID_Reservation).ToList();
            idReservations.Insert(0, "--Select Reservation--");
            
            idReservationcomboBox.DisplayMember = "ID_Reservation";
            idReservationcomboBox.ValueMember = "ID_Reservation";
            idReservationcomboBox.DataSource = idReservations;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showOrderService();
        }
        private void showMenuService()
        {
            IQueryable<Service> menu = Common.Intance.Services;
            var data = menu.Select(p => new { p.ID_Service,p.NameService,p.Price});
            menuServiceDTG.DataSource = data.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(menuServiceDTG.SelectedRows.Count > 0)
            {
                string idOrderService = menuServiceDTG.CurrentRow.Cells["ID_Service"].Value.ToString();
                if (! idReservationcomboBox.SelectedValue.ToString().Contains("--Select Reservation--"))
                {
                    string idOrderReservation = idReservationcomboBox.SelectedValue.ToString();
                    Service objService = Common.Intance.Services.Find(idOrderService);
                    Reservation objReservation = Common.Intance.Reservations.Find(idOrderReservation);
                    if(DateTime.Compare(objReservation.CheckOut,DateTime.Today) < 0)
                    {
                        MessageBox.Show("Room rental service has ended");
                    }
                    else
                    {
                        Service temp = objReservation.Services.SingleOrDefault(x => x.ID_Service == idOrderService);
                        if (temp != null)
                        {
                            MessageBox.Show("Service already exists !");
                        }
                        else
                        {
                            objReservation.Services.Add(objService);
                        }
                        Common.Intance.SaveChanges();
                    }

                    
                }
            }
            showOrderService();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (orderServiceDTG.SelectedRows.Count > 0)
            {
                List<string> deleteOrder = new List<string>();
                foreach (DataGridViewRow i in orderServiceDTG.SelectedRows)
                {
                    deleteOrder.Add(i.Cells["ID_Service"].Value.ToString());
                }
                if (!idReservationcomboBox.SelectedValue.ToString().Contains("--Select Reservation--"))
                {
                    string idOrderReservation = idReservationcomboBox.SelectedValue.ToString();
                    Reservation objReservation = Common.Intance.Reservations.Find(idOrderReservation);
                    foreach (string i in deleteOrder)
                    {
                        Service objService = objReservation.Services.SingleOrDefault(p =>p.ID_Service == i );
                        if(objService != null)
                        {
                            objReservation.Services.Remove(objService);
                        }
                    }
                }
            }
            Common.Intance.SaveChanges();
            showOrderService();
        }
    }
}
