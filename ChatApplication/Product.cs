using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Add_Product(object sender, EventArgs e)
        {
            int PId=int.Parse(txtID.Text);
            string PName=txtName.Text;
            int PQuantity=int.Parse(txtQuan.Text);
            int price =int.Parse( PriceBox.Text);

            Repository r1 = new Repository();
           if( r1.AddProduct(PId, PName, (PQuantity),price))
            {
                MessageBox.Show("Product added");
                
            }
           else
            {
                MessageBox.Show("Product id exists already");
            }
           
        }
       
       

    }

}
