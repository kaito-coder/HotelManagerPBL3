using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.Model;
using PBL3.View;

namespace PBL3.Forms
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            reservationDTG.DataSource = Common.Intance.Reservations.ToList();
            Today.Text = DateTime.Today.ToString();
            showRoom();
            UpdateStatusRoomByDTG();
            showReservation();
           


        }
        private void showReservation()
        {
            string nameCustomer = nameCustomerTxt.Text;
            string idRoom = roomCBB.SelectedValue.ToString();
            IQueryable<Reservation> list = Common.Intance.Reservations;
            if (nameCustomer != "")
            {
                list = list.Where(p => p.Customer.NameCustomer.Contains(nameCustomer));
            }
            if (idRoom != "ALL")
            {
                list = list.Where(p => p.Room.ID_Room.Contains(idRoom));
            }
            var data = list.Select(p => new { p.ID_Reservation, p.ID_Customer, p.Customer.NameCustomer, p.ID_Room, p.CheckIn, p.CheckOut });
            reservationDTG.DataSource = data.ToList();
        }
        private void showRoom()
        {

            IQueryable<Room> list = Common.Intance.Rooms;

            list = list.Where(p => p.StatusRoom.NameStatusRoom.Contains("Occupied"));
            List<Room> roomList = list.ToList();
            roomList.Insert(0, new Room() { ID_Room = "ALL" });

            roomCBB.DisplayMember = "ID_Room";
            roomCBB.ValueMember = "ID_Room";
            roomCBB.DataSource = roomList.ToList();



        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showReservation();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateReservation DetailForm = new AddOrUpdateReservation();
            DetailForm.ShowDialog();
            showReservation();
            showRoom();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string id_Reservation = reservationDTG.CurrentRow.Cells["ID_Reservation"].Value.ToString();
            AddOrUpdateReservation DetailForm = new AddOrUpdateReservation();
            DetailForm.ID_Reservation = id_Reservation;
            DetailForm.ID_RoomUpdate = reservationDTG.CurrentRow.Cells["ID_Room"].Value.ToString();
            DetailForm.ShowDialog();
            
            showReservation();
            UpdateStatusRoomByDTG();
            showRoom();


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            showReservation();

        }
        private void UpdateStatusRoomByDTG()
        {
            List<string> IdRoomDTG = new List<string>();
            List<string> IdRoomOccupied = new List<string>();

            foreach (DataGridViewRow i in reservationDTG.Rows)
            {
                DateTime CheckOut = Convert.ToDateTime(i.Cells["CheckOut"].Value.ToString());
                int res = DateTime.Compare(CheckOut, DateTime.Today);
                IdRoomDTG.Add(i.Cells["ID_Room"].Value.ToString());
                if (res >= 0)
                {
                    string ID_Room = i.Cells["ID_Room"].Value.ToString();
                    Room objRoom = Common.Intance.Rooms.Find(ID_Room);
                    objRoom.ID_StatusRoom = 3;
                    Common.Intance.SaveChanges();
                }
                else
                {
                    string ID_Room = i.Cells["ID_Room"].Value.ToString();
                    Room objRoom = Common.Intance.Rooms.Find(ID_Room);
                    objRoom.ID_StatusRoom = 1;
                    Common.Intance.SaveChanges();
                }
            }
            foreach (var i in Common.Intance.Rooms)
            {
                if (i.ID_StatusRoom == 3)
                {
                    IdRoomOccupied.Add(i.ID_Room);
                }
            }

            foreach (var j in IdRoomDTG)
            {
                if (IdRoomOccupied.Contains(j))
                {
                    IdRoomOccupied.Remove(j);
                }
            }
            foreach(var i in IdRoomOccupied)
            {
               Room objRoom =  Common.Intance.Rooms.Find(i);
                objRoom.ID_StatusRoom = 1;
            }
            Common.Intance.SaveChanges();


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string ID_ReservationDelete = reservationDTG.CurrentRow.Cells["ID_Reservation"].Value.ToString();
            string ID_CustomerDelete = reservationDTG.CurrentRow.Cells["ID_Customer"].Value.ToString();
            string ID_Room = reservationDTG.CurrentRow.Cells["ID_Room"].Value.ToString();
            Room objRoom = Common.Intance.Rooms.Find(ID_Room);
            objRoom.ID_StatusRoom = 1;
            Reservation objReservation = Common.Intance.Reservations.Find(ID_ReservationDelete);
            Customer objCustomer = Common.Intance.Customers.Find(ID_CustomerDelete);
            Common.Intance.Customers.Remove(objCustomer);
            Common.Intance.Reservations.Remove(objReservation);
            foreach(var i in Common.Intance.Bills)
            {
                if(i.ID_Reservation == ID_ReservationDelete)
                {
                    Common.Intance.Bills.Remove(i);
                    break;
                }
            }
            Common.Intance.SaveChanges();
            showReservation();



        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            AddBillForm DetailForm = new AddBillForm();
            string id_Reservation = reservationDTG.CurrentRow.Cells["ID_Reservation"].Value.ToString();
            DetailForm.IdReservation = id_Reservation;
            DetailForm.ShowDialog();
        }
    }
}
