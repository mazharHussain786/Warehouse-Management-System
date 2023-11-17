using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApplication.Models;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Register : Form
    {

        Users U1 = new Users();

        public Register()
        {
            
            InitializeComponent();
         //   GenderCombo.Items.Add("Male");
          //  GenderCombo.Items.Add("Female");
        }

        public void RegisterUser(object sender, EventArgs e)
        {
            // it should be store in DataBase..or array..
           
            U1.Email = EmailBox.Text;
            U1.UserName = UserNameBox.Text;
            U1.Password= PasswordBox.Text;
            Repository R1 = new Repository();
            if(R1.CreateUser(U1))
            {
                MessageBox.Show("User Created");
                
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
                
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void GenderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          //  U1.Gender=GenderCombo.SelectedItem.ToString();
        }
    }
}
