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
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();
            LoadProducts();
          
        }

        DataTable Product_Table = new DataTable();
        private DataTable load_Product()
        {

            ChatDataBaseContext cx = new ChatDataBaseContext();
            var Product_list = cx.Products.ToList();




            if (Product_list.Any())
            {
                // now we have to set columns name in DataTable

                Product_Table.Columns.Add("Key");
                Product_Table.Columns.Add("Name");
                Product_Table.Columns.Add("Quantity");
                Product_Table.Columns.Add("Price");

                foreach (var data in Product_list)
                {
                    DataRow r1 = Product_Table.NewRow();
                    r1["Key"] = data.PId;
                    r1["Name"] = data.Name;
                    r1["Quantity"] = data.Quantity;
                    r1["Price"] = data.price;
                    Product_Table.Rows.Add(r1);
                }






            }
            return Product_Table;
        }

        private void LoadProducts()
        {
            // Retrieve product data from the database and set it in the DataGridView
            DataTable productsTable = load_Product();

            // Set the DataGridView's DataSource to the DataTable
            MyGrid.DataSource = productsTable;

            // Create a button column for removing products
        }
    }
}
