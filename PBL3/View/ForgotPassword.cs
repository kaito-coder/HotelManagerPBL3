using PBL3.DTO;
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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
             string username = usernameTXT.Text;
            string cccd = cccdTxt.Text;
            string phone = phoneTxt.Text;
            bool check1 = false;
            bool check2 = false;

            foreach (Account i in Common.Intance.Accounts)
            {
                if(i.UserName == username)
                {
                    check1 = true;
                }
                break;
            }
            foreach(Employee i in Common.Intance.Employees)
            {
                if(i.CCCD == cccd && i.Phone == phone)
                {
                    check2 = true;
                    if (check1)
                    {
                        MessageBox.Show($"Your password is {i.Account.Password}");
                    }
                }
                break;
            }
            if (!check1)
            {
                MessageBox.Show("Username incorrect !");
            }
            else
            {
                if (!check2)
                {
                    MessageBox.Show("CCCD or Phone incorrect !");
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
