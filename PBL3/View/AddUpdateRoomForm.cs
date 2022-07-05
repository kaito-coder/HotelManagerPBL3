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
    public partial class AddUpdateRoomForm : Form
    {
        private string _ID_Room;
        public string ID_Room { get => _ID_Room; set => _ID_Room = value; }

        public AddUpdateRoomForm()
        {
            InitializeComponent();
        }

        private void GUI()
        {
            Room objRoom = Common.Intance.Rooms.Find(_ID_Room);
            if(objRoom != null)
            {
                idRoomtxt.Text = objRoom.ID_Room.ToString();
                idRoomtxt.Enabled = false;
                typeRoomCBB.SelectedValue = objRoom.ID_TypeRoom;
                statusRoomCBB.SelectedValue = objRoom.ID_StatusRoom;
                

            }
        }
        private void listTypeRoom()
        {
            List<TypeRoom> listTypeRoom = Common.Intance.TypeRooms.ToList();
            listTypeRoom.Insert(0, new TypeRoom() { ID_TypeRoom = 0, NameTypeRoom = "--Select TypeRoom-- " });
            typeRoomCBB.DisplayMember = "NameTypeRoom";
            typeRoomCBB.ValueMember = "ID_TypeRoom";
            typeRoomCBB.DataSource = listTypeRoom;
        }
        private void listStatusroom()
        {
            List<StatusRoom> listStatusRoom = Common.Intance.StatusRooms.ToList();
            listStatusRoom.Insert(0, new StatusRoom() { ID_StatusRoom = 0, NameStatusRoom = "--Select StatusRoom--" });
            statusRoomCBB.DisplayMember = "NameStatusRoom";
            statusRoomCBB.ValueMember = "Id_StatusRoom";
            statusRoomCBB.DataSource = listStatusRoom;

        }
        private void AddUpdateRoomForm_Load(object sender, EventArgs e)
        {
            listStatusroom();
            listTypeRoom();
            if (!string.IsNullOrEmpty(_ID_Room))
            {
                GUI();
            }
            

        }

        
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            bool isInsert = true;
            Room objRoom = null;
            if (!string.IsNullOrEmpty(_ID_Room))
            {
                objRoom = Common.Intance.Rooms.Find(_ID_Room);
            }
            if(objRoom != null)
            {
                isInsert = false;
            }
            else
            {
                objRoom = new Room();
            }
            objRoom.ID_Room = idRoomtxt.Text;
            objRoom.ID_StatusRoom = Convert.ToInt32(statusRoomCBB.SelectedValue.ToString());
            objRoom.ID_TypeRoom = Convert.ToInt32(typeRoomCBB.SelectedValue.ToString());
            
            if (isInsert)
            {
                Common.Intance.Rooms.Add(objRoom);
            }
            Common.Intance.SaveChanges();
            this.Close();
        }

        
    }
}
