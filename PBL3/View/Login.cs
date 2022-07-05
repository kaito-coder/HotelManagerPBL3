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

namespace PBL3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            userNameTxt.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            passwordTxt.BackColor = SystemColors.Control;
            
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            passwordTxt.BackColor = Color.White;
            panel4.BackColor= Color.White;
            userNameTxt.BackColor = SystemColors.Control;
            panel3.BackColor= SystemColors.Control;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTxt.UseSystemPasswordChar=false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text.ToString();
            string password = passwordTxt.Text.ToString();
            bool find = false;
            if(userName == "")
            {
                MessageBox.Show("Please enter username !");
            }
            else
            {
                if(password == "")
                {
                    MessageBox.Show("Please enter Password !");
                }
                else
                {
                    foreach (var i in Common.Intance.Employees.ToList())
                    {
                        if (i.Account.UserName == userName && i.Account.Password == password)
                        {
                            MainForm mainForm = new MainForm(); 
                            mainForm.Role = i.Role;
                            mainForm.ShowDialog();                            
                            this.Close();
                            find = true;
                            break;

                        }
                    }
                    if (find == false)
                    {
                        MessageBox.Show("Account or password is not precision !");
                    }
                }
            }
            
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword detailForm = new ForgotPassword();
            detailForm.ShowDialog();

        }
    }
}
