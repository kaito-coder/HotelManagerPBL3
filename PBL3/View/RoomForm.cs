using PBL3.Model;
using PBL3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Forms
{
    public partial class RoomForm : Form
    {
        private string _Role;

        public string Role { get => _Role; set => _Role = value; }

        public RoomForm()
        {
            InitializeComponent();
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
            statusCBB.DisplayMember = "NameStatusRoom";
            statusCBB.ValueMember = "Id_StatusRoom";
            statusCBB.DataSource = listStatusRoom;

        }
        private void ShowRoom()
        {
            string rooms = roomTxt.Text.Trim().ToString();
            int idStatusRoom = Convert.ToInt16(statusCBB.SelectedValue.ToString());
            int idTypeRoom = Convert.ToInt16(typeRoomCBB.SelectedValue.ToString());
            IQueryable<Room> listRoom = Common.Intance.Rooms;
            if(rooms != "")
            {
                listRoom = listRoom.Where(p => p.ID_Room.Contains(rooms));
            }
            if(idStatusRoom != 0)
            {
                listRoom = listRoom.Where(p => p.ID_StatusRoom == idStatusRoom);
            }
            if (idTypeRoom != 0)
            {
                listRoom = listRoom.Where(p => p.ID_TypeRoom == idTypeRoom);
            }
            if (pricecomboBox.SelectedIndex == 1)
            {
                listRoom = from room in listRoom
                            orderby room.TypeRoom.PriceTypeRoom descending
                           select room;
            }
            else
            {
                listRoom = from room in listRoom
                           orderby room.TypeRoom.PriceTypeRoom 
                           select room;

            }
            var data = listRoom.Select(p => new { p.ID_Room, p.StatusRoom.NameStatusRoom, p.TypeRoom.NameTypeRoom,p.TypeRoom.PriceTypeRoom });
            roomDTG.DataSource = data.ToList();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            ShowRoom();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            if(_Role == "User")
            {
                addButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            listTypeRoom();
            listStatusroom();
            ShowRoom();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowRoom();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddUpdateRoomForm DetailForm = new AddUpdateRoomForm();
            DetailForm.ShowDialog();
            ShowRoom();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            AddUpdateRoomForm DetailForm = new AddUpdateRoomForm();
            DetailForm.ID_Room = roomDTG.CurrentRow.Cells["ID_Room"].Value.ToString();
            DetailForm.ShowDialog();
            ShowRoom();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure to delete the room ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                List<string> roomDelete = new List<string>();
                if (roomDTG.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in roomDTG.SelectedRows)
                    {
                        roomDelete.Add(i.Cells["ID_Room"].Value.ToString());
                    }
                }
                if (roomDelete.Count > 0)
                {
                    foreach (var i in roomDelete)
                    {
                        Room obj = Common.Intance.Rooms.Find(i);
                        Common.Intance.Rooms.Remove(obj);
                        Common.Intance.SaveChanges();
                            
                    }
                }
            }
            ShowRoom();
        }
    }
}
