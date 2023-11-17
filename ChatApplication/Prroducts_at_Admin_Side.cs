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
    public partial class Prroducts_at_Admin_Side : UserControl
    {
        public  Prroducts_at_Admin_Side()
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

                foreach(var data in Product_list)
                {
                    if (data.Quantity > 0)
                    {


                        DataRow r1 = Product_Table.NewRow();
                        r1["Key"] = data.PId;
                        r1["Name"] = data.Name;
                        r1["Quantity"] = data.Quantity;
                        r1["Price"] = data.price;
                        Product_Table.Rows.Add(r1);

                    }
                    else
                    {
                        cx.Products.Remove(data);
                    }
                }


                    
                


            }
            return Product_Table;
        }

        private void LoadProducts()
        {
            // Retrieve product data from the database and set it in the DataGridView
            DataTable productsTable = load_Product();

            // Set the DataGridView's DataSource to the DataTable
                dgvProducts.DataSource = productsTable;

            // Create a button column for removing products
            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Remove",
                Text = "Remove Product",
                UseColumnTextForButtonValue = true,
                HeaderText = "Actions"
            };

            removeButtonColumn.UseColumnTextForButtonValue = true;

            dgvProducts.Columns.Add(removeButtonColumn);
            dgvProducts.CellContentClick += new DataGridViewCellEventHandler(remove);




        }
                    
        /*
              private void remove(object sender , EventArgs e)
                {
                    int rowIndex=dgvProducts.CurrentCell.RowIndex;
                    object keyCellValue = dgvProducts.Rows[rowIndex].Cells["Key"].Value;

                    MessageBox.Show(""+keyCellValue);
                    LoadProducts();

                }
        */
        private void remove(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProducts.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                object keyCellValue = dgvProducts.Rows[rowIndex].Cells["Key"].Value;

                // Ensure that keyCellValue is not null before trying to use it.
                if (keyCellValue != null)
                {
                    int productId;
                    if (int.TryParse(keyCellValue.ToString(), out productId))
                    {
                        // Use productId for removal or any other operations you need.
                        // Call a method to remove the product, e.g., r1.RemoveProduct(productId)
                        Repository r1 = new Repository();
                        if(r1.RemoveProduct(productId))
                        {
                            MessageBox.Show("Product with ID " + productId + " is removed.");

                        }
                        


                        // You can call LoadProducts to refresh the DataGridView.
                        // LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Invalid product ID");
                    }
                }
                else
                {
                    MessageBox.Show("No product ID in this row.");
                }
            }
        }



    }
}
