using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class RegisterUser : UserControl
    {
        Users U1 = new Users();
        public RegisterUser()
        {
            InitializeComponent();
        }
        public void Register(object sender, EventArgs e)
        {
            // it should be store in DataBase..or array..

            U1.Email = EmailText.Text;
            U1.UserName = UserText.Text;
            U1.Password = PassText.Text;
            Repository R1 = new Repository();
            if (R1.CreateUser(U1))
            {
                MessageBox.Show("User Created");

            }
            else
            {
                MessageBox.Show("Something Went Wrong");

            }

        }

    }
}
