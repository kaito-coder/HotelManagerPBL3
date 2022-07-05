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
    public partial class AddOrUpdateReservation : Form
    {
        private string _ID_Reservation;
        private string _ID_Customer;
        public string ID_RoomUpdate;
        public string ID_Reservation { get => _ID_Reservation; set => _ID_Reservation = value; }
        public string ID_Customer { get => _ID_Customer; set => _ID_Customer = value; }

        public AddOrUpdateReservation()
        {
            InitializeComponent();
        }
        private void Gui()
        {
            Reservation objReservation = Common.Intance.Reservations.Find(_ID_Reservation);
            if(objReservation != null)
            {
                idReservationTxT.Text = objReservation.ID_Reservation.ToString();
                idCustomerTxt.Text = objReservation.ID_Customer.ToString();
                idCustomerTxt.Enabled = false;
                nameCustomerTxt.Text = objReservation.Customer.NameCustomer.ToString();
                maleRadio.Checked = objReservation.Customer.Gender;
                phoneTxt.Text = objReservation.Customer.Phone.ToString();
                cccdTextBox.Text = objReservation.Customer.CCCD.ToString();
              //  typeRoomCBB.SelectedValue = objReservation.Room.ID_TypeRoom.ToString();
                roomCBB.SelectedValue = objReservation.Room.ID_Room.ToString();
                checkInDTP.Value = objReservation.CheckIn;
                checkOutDTP.Value = objReservation.CheckOut;
            }

        }
        

        private void AddOrUpdateReservation_Load(object sender, EventArgs e)
        {
            checkInDTP.Value = DateTime.Today;
            //listTypeRoom();
            ListRoom();
            if (!string.IsNullOrEmpty(_ID_Reservation))
            {
               
                Gui();
            }
            
           
        }
        
        /*private void listTypeRoom()
        {
            List<TypeRoom> listTypeRoom = Common.Intance.TypeRooms.ToList();
            listTypeRoom.Insert(0, new TypeRoom() { ID_TypeRoom = 0, NameTypeRoom = "--Select TypeRoom-- " });
            typeRoomCBB.DisplayMember = "NameTypeRoom";
            typeRoomCBB.ValueMember = "ID_TypeRoom";
            typeRoomCBB.DataSource = listTypeRoom;
            IQueryable<Room> listRoom = Common.Intance.Rooms;
            
        }*/
        private void ListRoom()
        {
            IQueryable<Room> list = Common.Intance.Rooms;
            Room UpdateRoom = Common.Intance.Rooms.Find(ID_RoomUpdate);

            list = list.Where(p => p.StatusRoom.NameStatusRoom.Contains("Vacant and ready"));         
            List<Room> roomList = list.ToList();
            if(UpdateRoom != null)
            {
                roomList.Add(UpdateRoom);
            }
            roomList.Insert(0, new Room() { ID_Room = "--Select Room--" });
            roomCBB.DisplayMember = "ID_Room";
            roomCBB.ValueMember = "ID_Room";
            roomCBB.DataSource = roomList.ToList(); 
        }
        


        private void okButton_Click(object sender, EventArgs e)
        {
            bool isInsert = true;
            Reservation objReservation = null;
            Customer objCustomer = null;
            if (!string.IsNullOrEmpty(_ID_Reservation))
            {
                objReservation = Common.Intance.Reservations.Find(_ID_Reservation);
            }
            if (objReservation != null)
            {
                isInsert = false;
                objCustomer = objReservation.Customer;
            }
            else
            {
                objCustomer = new Customer();
                objReservation = new Reservation();
                
            }
            
            objReservation.ID_Reservation =idReservationTxT.Text;
            objReservation.ID_Customer = idCustomerTxt.Text;
            objReservation.ID_Room = roomCBB.SelectedValue.ToString();
            objCustomer.ID_Customer = idCustomerTxt.Text;
            objCustomer.NameCustomer = nameCustomerTxt.Text;
            objCustomer.Gender = maleRadio.Checked;
            objCustomer.Phone = phoneTxt.Text;
            objCustomer.CCCD = cccdTextBox.Text;
            objReservation.CheckIn = checkInDTP.Value;
            objReservation.CheckOut = checkOutDTP.Value;

            if (isInsert)
            {
                objCustomer.ID_Customer = idCustomerTxt.Text;
                objCustomer.NameCustomer = nameCustomerTxt.Text;
                objCustomer.Gender = maleRadio.Checked;
                objCustomer.Phone = phoneTxt.Text;
                objCustomer.CCCD = cccdTextBox.Text;
                Common.Intance.Customers.Add(objCustomer);  
                Common.Intance.Reservations.Add(objReservation);
            }
            updateStatusRoom(roomCBB.SelectedValue.ToString());
            Common.Intance.SaveChanges();
            ID_RoomUpdate = "";
            MessageBox.Show("Reservation Successfully Edited");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void typeRoomCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
/*
            IQueryable<Room> list = Common.Intance.Rooms;
            list = list.Where(p => p.StatusRoom.NameStatusRoom.Contains("Vacant and ready"));
       //     int ID_TypeRoom = Convert.ToUInt16(typeRoomCBB.SelectedValue.ToString());
            //list = list.Where(p => p.ID_TypeRoom == ID_TypeRoom);
            List<Room> roomList = list.ToList();
            roomList.Insert(0, new Room() { ID_Room = "--Select Room--" });
            roomCBB.DisplayMember = "ID_Room";
            roomCBB.ValueMember = "ID_Room";
            roomCBB.DataSource = roomList.ToList();*/

        }

        private void updateStatusRoom(string ID_Room)
        {
            Room objRoom = Common.Intance.Rooms.Find(ID_Room);
            if(objRoom.StatusRoom.NameStatusRoom.Contains("Vacant and ready")){
                objRoom.ID_StatusRoom = 3;
            }
            if (objRoom.StatusRoom.NameStatusRoom.Contains("Occupied ")){
                objRoom.ID_StatusRoom = 1;
            }


        }

        private void checkInDTP_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(checkInDTP.Value, DateTime.Today);
            if(res < 0){
                MessageBox.Show("Reselect Check-in date !!");
            }
        }

        private void checkOutDTP_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(checkOutDTP.Value, checkInDTP.Value);
            if (res < 0)
            {
                MessageBox.Show("Reselect Check-out date !!");
            }
        }

        
    }
}
