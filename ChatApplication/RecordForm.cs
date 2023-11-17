using ChatApplication.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class RecordForm : UserControl
    {
        public RecordForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (ChatDataBaseContext cx = new ChatDataBaseContext())
            {
                var orderList = cx.Orders.ToList();
                Total.Text = orderList.Count.ToString();
                Shipped.Text = cx.Orders.Count(c => c.Status == "Shipped").ToString();

                // Clear existing rows and add column headers
                dataGridView1.Rows.Clear();
                if (orderList.Any())
                {
                    AddColumnHeaders();
                    foreach (var data in orderList)
                    {
                        dataGridView1.Rows.Add(
                            data.OrderId,
                            data.Status,
                            data.OrderPlacedTime,
                            data.Adress,
                            data.CustomerCNIC,
                            data.DeliveryDate,
                            data.ShipingMethod,
                            data.items
                        );
                    }
                }

                // Populate OrderBox with OrderId values for orders with "Processing" status
                foreach (var v in orderList.Where(o => o.Status == "Processing"))
                {
                    OrderBox.Items.Add(v.OrderId);
                }

                // Add items to Status and ShippingBox ComboBoxes
                Status.Items.Add("Shipped");
                ShippingBox.Items.AddRange(new string[] { "United Parcel Service", "USPS", "DHL" });
            }
        }

        private void AddColumnHeaders()
        {
            dataGridView1.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "OrderId", HeaderText = "Order ID" },
                new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status" },
                new DataGridViewTextBoxColumn { Name = "OrderPlacedTime", HeaderText = "Order Placed Time" },
                new DataGridViewTextBoxColumn { Name = "Address", HeaderText = "Address" },
                new DataGridViewTextBoxColumn { Name = "CustomerCNIC", HeaderText = "Customer Email" },
                new DataGridViewTextBoxColumn { Name = "DeliveryDate", HeaderText = "Delivery Date" },
                new DataGridViewTextBoxColumn { Name = "ShippingMethod", HeaderText = "Shipping Method" },
                new DataGridViewTextBoxColumn { Name = "Items", HeaderText = "Items" }
            );
        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            var selectedStatus = Status.SelectedItem?.ToString();
            var orderId = OrderBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedStatus) || string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Fields are empty");
                return;
            }

            using (ChatDataBaseContext cx = new ChatDataBaseContext())
            {
                var order = cx.Orders.FirstOrDefault(c => c.OrderId == orderId);
                if (order != null)
                {
                    order.ShipingMethod = ShippingBox.SelectedItem?.ToString();
                    order.Status = selectedStatus;
                    cx.SaveChanges();

                    // Update Shipped count after changing status
                    Shipped.Text = cx.Orders.Count(c => c.Status == "Shipped").ToString();

                    MessageBox.Show("Status Changed Done");

                    // Reload data after making changes
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Order not found");
                }
            }
        }
    }
}
