using ChatApplication.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class TrackProduct : UserControl
    {
        public TrackProduct()
        {
            InitializeComponent();
            LoadOrderIds();
        }

        private void LoadOrderIds()
        {
            using (ChatDataBaseContext cx = new ChatDataBaseContext())
            {
                var orders = cx.Orders.ToList();
                comboBox1.Items.AddRange(orders.Select(order => order.OrderId).ToArray());
            }
        }

        private void TrackButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an Order ID");
                return;
            }

            using (ChatDataBaseContext cx = new ChatDataBaseContext())
            {
                var orderId = comboBox1.SelectedItem.ToString();
                var product = cx.Orders.FirstOrDefault(c => c.OrderId == orderId);

                label2.Text = "Status : "+product.Status;

                if (product.Status == "Processing")
                {
                    line.Text = "Order is not shipped yet";
                }
                else
                {
                    // Parse the DeliveryDate string into a DateTime object
                    if (!DateTime.TryParse(product.DeliveryDate, out DateTime deliveryDateTime))
                    {
                        MessageBox.Show("Error parsing DeliveryDate");
                        return;
                    }

                    if (deliveryDateTime <= product.OrderPlacedTime)
                    {
                        line.Text = "Order is delivered";
                        return;
                    }

                    TimeSpan timeDifference = deliveryDateTime - product.OrderPlacedTime;

                    if (timeDifference.TotalDays >= 1)
                    {
                        line.Text = $"Order will reach in: {Math.Floor(timeDifference.TotalDays)} days";
                    }
                    else if (timeDifference.TotalHours >= 1)
                    {
                        line.Text = $"Order will reach in: {Math.Floor(timeDifference.TotalHours)} hours";
                    }
                    else
                    {
                        line.Text = $"Order will reach in: {Math.Floor(timeDifference.TotalMinutes)} minutes";
                    }
                }
            }
        }

        private void TrackProduct_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
