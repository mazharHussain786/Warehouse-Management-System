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
    public partial class Menu : Form
    {
        DataTable dt = new DataTable();
        public Menu()
        {
            InitializeComponent();
            
        }
        
        public void display()
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Status");
            dt.Columns.Add("Gender");
            Repository R1 = new Repository();
            var Users = R1.GetAllUsers();
            foreach (var user in Users)
            {
                DataRow dr = dt.NewRow();
                dr[0] = user.UserName;
              //  dr[1] = user.Status;
               // dr[2] = user.Gender;
                dt.Rows.Add(dr);
                
            }
          //  dataGridView1.DataSource = dt;
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_User(object sender, EventArgs e)
        {
            RegisterPanel.Invoke((MethodInvoker)delegate
            {
                RegisterPanel.Controls.Clear();
                RegisterUser r1 = new RegisterUser();
                r1.Dock = DockStyle.Fill;
                RegisterPanel.Controls.Add(r1);
            }); ;
        }
        private void Add_Product(object sender, EventArgs e)
        {
            RegisterPanel.Invoke((MethodInvoker)delegate
            {
                RegisterPanel.Controls.Clear();
                Product p1 = new Product();
                p1.Dock = DockStyle.Fill;
                RegisterPanel.Controls.Add(p1);
               
            }); ;
        }

        private void Logout(object sender, EventArgs e)
        {
            this.Close();
            Form1 HomePage = new Form1();
            HomePage.Show();
        }
        private void DealProducts(object sender, EventArgs e)
        {
            RegisterPanel.Controls.Clear();
            Prroducts_at_Admin_Side p1 = new Prroducts_at_Admin_Side();
            
            p1.Dock = DockStyle.Fill;
            RegisterPanel.Controls.Add(p1);
        }
        private void  CalculateBill(object sender , EventArgs e)
        {
            RegisterPanel.Controls.Clear();
            PurshaseForm p1 = new PurshaseForm();
            p1.Dock = DockStyle.Fill;
            RegisterPanel.Controls.Add(p1);
        }
        private void putRecord(object sender , EventArgs e)
        {
            RegisterPanel.Controls.Clear();
            RecordForm r1 = new RecordForm();
            r1.Dock = DockStyle.Fill;
            RegisterPanel.Controls.Add(r1);
        }

        private void Track(object sender, EventArgs e)
        {
            RegisterPanel.Controls.Clear();
            TrackProduct r1 = new TrackProduct();
            r1.Dock = DockStyle.Fill;
            RegisterPanel.Controls.Add(r1);
        }
        private void Remove(object sender, EventArgs e)
        {
            RegisterPanel.Controls.Clear();
            RemoveUser r1 = new RemoveUser();
            r1.Dock = DockStyle.Fill;
            RegisterPanel.Controls.Add(r1);
        }

    }
}
