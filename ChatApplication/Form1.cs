using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoginButton(object sender, EventArgs e)
        {
            
               
            ChatDataBaseContext cx = new ChatDataBaseContext();
            Users u1 = new Users();
            var v1 = cx.Users.FirstOrDefault(c => c.Password == PasswBox.Text && c.Email == EmailBox.Text);
            if (v1 != null)
            {
                if (v1.Status)
                { 
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    return;
                }
                UserHomePage u = new UserHomePage();
                u.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed");
               
            }

          
        }

        private void RegisterButton(object sender, EventArgs e)
        {
            // Return the next Form..
            Register R1= new Register();
            R1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Moogle_Chat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
