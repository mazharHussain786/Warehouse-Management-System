using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Linq;
using System.Windows.Forms;
using ChatApplication.Models;

namespace ChatApplication
{
    public partial class RemoveUser : UserControl
    {
        public RemoveUser()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (ChatDataBaseContext cx = new ChatDataBaseContext())
            {
                // Get users with Status == false
                var users = cx.Users.Where(c => c.Status == false).ToList();

                // Bind the users data to the DataGridView
                dataGridView1.DataSource = users;
                foreach(var user in users)
                {
                    comboBox1.Items.Add(user.Email);
                }
                

                // Optionally, you can customize the DataGridView appearance
                CustomizeDataGridView();
            }
        }

        private void CustomizeDataGridView()
        {
            // Optional: Customize the appearance of the DataGridView
            // For example, you can set column headers and adjust column widths
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["Password"].HeaderText = "Password";
            dataGridView1.Columns["UserName"].HeaderText = "User Name";
            dataGridView1.Columns["Status"].HeaderText = "Status";

            // Set the Status column to be displayed as a checkbox
            dataGridView1.Columns["Status"].DefaultCellStyle.NullValue = false;
            dataGridView1.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set other properties as needed
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var Email = comboBox1.SelectedItem.ToString();
            ChatDataBaseContext cx = new ChatDataBaseContext();
            var data = cx.Users.FirstOrDefault(c => c.Email == Email);
            cx.Users.Remove(data);
            cx.SaveChanges();
            MessageBox.Show($"{data.UserName} Successdully Removed ");
           
        }
    }
}


