using ChatApplication.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ChatApplication
{
    public partial class PurshaseForm : UserControl
    {
        static public List<P> Selection=new List<P>();
        static public double Bill { get; set; }
        
        public PurshaseForm()
        {
            InitializeComponent();
            Cart.Text = string.Empty;
            load_Data();
        }
        public void load_Data()
        {
            ChatDataBaseContext cx = new ChatDataBaseContext();
            var productList=cx.Products.ToList();
            foreach (var product in productList) 
            { 
                if(product.Quantity>0)
                {
                    List.Items.Add(product.Name);
                } 
            }
            var emails = cx.Users.Where(c => c.Status == false).ToList();
            foreach (var e in emails)
            {
                EmailBox.Items.Add(e.Email);
            }
        } 
    

     

        private void Button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Cart.Text))
            {
                MessageBox.Show("Your Cart is empty ...!!");
                return;
            }
            else if (EmailBox.SelectedItem == null || string.IsNullOrEmpty(orderId.Text))
            {
                MessageBox.Show(" Some fields are empty ");
                return;
            }
            else
            {
                Order o1 = new Order();
                o1.CustomerCNIC = EmailBox.SelectedItem.ToString();
                o1.Adress = Adress.Text;
                o1.Status = "Processing";
                o1.OrderPlacedTime = DateTime.Now;
                o1.OrderId = orderId.Text;
                o1.DeliveryDate = dateTimePicker1.Value.ToString();
                o1.ShipingMethod = "None";
                foreach (var p in Selection)
                {
                    o1.items += p.Name;
                }
                // Now we have to genare invoice..

                ChatDataBaseContext cx = new ChatDataBaseContext();
                cx.Orders.Add(o1);
                double price = 0;
                string products = " ";
                products = "Customer Email : " + o1.CustomerCNIC + Environment.NewLine;
                products += " Date : " + DateTime.Now + Environment.NewLine;
                foreach (var p in Selection)
                {
                    var item = cx.Products.FirstOrDefault(c => c.Name == p.Name);

                    double price1 = 0;
                    if (item != null)
                    {
                        price += (p.Quantity * item.price);
                        price1 = p.Quantity * item.price;
                        products += item.Name + "  Quantity : " + item.Quantity + "  Price  : " + price1 + Environment.NewLine;
                        item.Quantity -= p.Quantity;
                        cx.SaveChanges();
                    }
                   
     
                }

                MessageBox.Show(products + "  \nTotal :  " + price);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (List.SelectedItem == null || string.IsNullOrEmpty(Quantity.Text))
            {
                MessageBox.Show(" Some Fields are empty !!");
                return;
            }
            var item = List.SelectedItem;
            var _Quantity = Convert.ToInt32(Quantity.Text);
           

            P p1 = new P();



            // product 
            // Quantity

            ChatDataBaseContext cx = new ChatDataBaseContext();

            // Attempt to get the item's price
            var SelectedItem = cx.Products.FirstOrDefault(c => c.Name == item);

            if (SelectedItem != null)
            {


                var orignal_Quantity = SelectedItem.Quantity;

                if (orignal_Quantity < _Quantity || _Quantity <= 0)
                {
                    MessageBox.Show("Quantity should be in limit. ");
                    return ;
                }
                p1.Name = SelectedItem.Name;
                p1.price = SelectedItem.price;
                p1.Quantity = _Quantity;
                Selection.Add(p1);

                cx.SaveChanges();

            }
            string Items = "";
            string OrderItems = "";

            foreach (var p in Selection)
            {
                Bill = Bill + p.price * p.Quantity;
                OrderItems = OrderItems + p.Name + "  Price: " +p.price+ "  Quantity: " + p.Quantity.ToString() + "  Item-Total :  "+ p.price*p.Quantity+ Environment.NewLine;
                Items = OrderItems + "Bill : " + Bill;
            }
            Cart.Text = OrderItems;

        }
    }
    public class P
    {
        public int Quantity { get; set; }
        public string Name { get; set; }

        public double price { get; set; }
    }

}
